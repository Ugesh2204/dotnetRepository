using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthenticationandAuthorization.Data;
using AuthenticationandAuthorization.HangFire_service;
using AuthenticationandAuthorization.Hubs;
using AuthenticationandAuthorization.Models;
using Hangfire;
using Hangfire.SqlServer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AuthenticationandAuthorization
{
    public class Startup
    {
        IConfiguration Configuration { get; }

        public Startup(IConfiguration _Configuration)
        {
            Configuration = _Configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //This is our connection string from appsetting.json
            services.AddDbContext<AppDbContext>(options =>options
            .UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));



            //Hangfire

            services.AddHangfire(configuration => configuration
               .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
               .UseSimpleAssemblyNameTypeSerializer()
               .UseRecommendedSerializerSettings()
               .UseSqlServerStorage(Configuration.GetConnectionString("DefaultConnection"), new SqlServerStorageOptions
               {
                   CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                   SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                   QueuePollInterval = TimeSpan.Zero,
                   UseRecommendedIsolationLevel = true,
                   DisableGlobalLocks = true
               }));





            //3
            //services.AddDbContext<AppDbContext>();

            //4
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();


            //Password settings

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
                options.Password.RequiredUniqueChars = 6;

                //Lockout settings
                //If the user failed to logout after 10 attemp it can re try after 30mins
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 10;

                //user settings
                options.User.RequireUniqueEmail = true;

                //will block all the user who has not confirm thier email
                //options.SignIn.RequireConfirmedEmail = true;

            });

            //Cookies
            //So if a user login and leave the system empty without doing Anything
            //than cooki will expire after 30 min
            services.ConfigureApplicationCookie(options =>
            {
                //Cookies settings
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                //if the loginPath isnt set. asp.net core defaults
                //the path to /Account/login.
                //When i am trying to access student it is taking me to Account/login
                options.LoginPath = "/Account/Login";
                //If the AccessDeniedPath isnt set Asp.net Core defaults
                //the path to /Account/AcessDenied
                options.AccessDeniedPath = "/Account/AccessDenied";

            });

            services.AddSignalR();

            services.AddHangfireServer();
            services.AddSingleton<IPrintjob, Printjob>();
            services.AddSingleton<IMyEmailService, MyEmailService>();



            services.AddMvc();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, 
            IBackgroundJobClient backgroundJobs,
            IRecurringJobManager recurringJobManager,
            IServiceProvider serviceProvider,
            IHostingEnvironment env)
        {
            app.UseStaticFiles();

            //5
            app.UseAuthentication();

            // Hangfire
            app.UseHangfireDashboard();
            //backgroundJobs.Enqueue(() => Console.WriteLine("Hello world from Ritesh!"));

            //Send every Minutes
            //recurringJobManager.AddOrUpdate(
            //    "Run every minute",
            //    () => Console.WriteLine("Test recurring job"),
            //    "* * * * * "
            //);

            //recurringJobManager.AddOrUpdate(
            //   "Run every minute from method class",
            //   () => serviceProvider.GetService<IPrintjob>().Print(),
            //   "* * * * * "
            //);

            //recurringJobManager.AddOrUpdate(
            //"Send email every Minutes",
            //() => serviceProvider.GetService<IMyEmailService>().SendEmail("ugesh.roopchand22@gmail.com", "Test sub","This body"),
            //"* * * * * "
            //);


            //Maping SignalR hub

            app.UseSignalR(routes =>
            {
                routes.MapHub<WeatherHub>("/weatherHub");
                routes.MapHub<ChatHub>("/chatHub");
                routes.MapHub<NotificationHub>("/notificationHub");
            });


            app.UseMvc(routes => //Configure
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

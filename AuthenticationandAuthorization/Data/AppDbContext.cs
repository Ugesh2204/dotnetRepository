using AuthenticationandAuthorization.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationandAuthorization.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=DESKTOP-7BGFQJH;Database=GymDb2020;Trusted_Connection=True;");
        //}


        //wE ADD THE CONNECTION STRING inside appsetting.json
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }


        public DbSet<Student> Students { get; set; }

        public DbSet<UserDetail> UserDetail { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<SingleDetails> SingleDetails { get;set;}
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<Membership_Price> Membership_Prices { get; set; }
        public DbSet<Subcription> Subcriptions { get; set; }

        //a application user have 1 or more messages
        public DbSet<Message>Messages { get; set; }

        //public DbSet<Department>Departments { get; set; }
        //public DbSet<Employee>Employees { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }



    }
}

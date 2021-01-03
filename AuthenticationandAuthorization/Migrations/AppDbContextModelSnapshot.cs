﻿// <auto-generated />
using System;
using AuthenticationandAuthorization.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuthenticationandAuthorization.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuthenticationandAuthorization.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<int>("Feet");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<string>("ImageUrl");

                    b.Property<double>("Inch");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("AuthenticationandAuthorization.Models.Membership", b =>
                {
                    b.Property<int>("MembershipId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MembershipType");

                    b.HasKey("MembershipId");

                    b.ToTable("Memberships");
                });

            modelBuilder.Entity("AuthenticationandAuthorization.Models.Membership_Price", b =>
                {
                    b.Property<int>("PriceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MembershipId");

                    b.Property<double>("Price");

                    b.HasKey("PriceId");

                    b.HasIndex("MembershipId");

                    b.ToTable("Membership_Prices");
                });

            modelBuilder.Entity("AuthenticationandAuthorization.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Comment_status");

                    b.Property<string>("FromUserId");

                    b.Property<string>("FromUserName");

                    b.Property<string>("MessageBody");

                    b.Property<DateTime>("MessageDtTm");

                    b.Property<string>("MessageHeader");

                    b.Property<int>("ToUserId");

                    b.Property<string>("ToUserName");

                    b.Property<string>("Url");

                    b.HasKey("MessageId");

                    b.HasIndex("FromUserId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("AuthenticationandAuthorization.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsRead");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("AuthenticationandAuthorization.Models.NotificationApplicationUser", b =>
                {
                    b.Property<int>("NotificationId");

                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("NotificationId1");

                    b.HasKey("NotificationId", "ApplicationUserId");

                    b.HasAlternateKey("NotificationId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("NotificationId1");

                    b.ToTable("UserNotifications");
                });

            modelBuilder.Entity("AuthenticationandAuthorization.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("Color")
                        .IsRequired();

                    b.Property<bool>("IsSelling");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("AuthenticationandAuthorization.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<bool>("IsMain");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("AuthenticationandAuthorization.Models.SingleDetails", b =>
                {
                    b.Property<int?>("UserlogInId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("ImagePhoto");

                    b.Property<string>("UserName");

                    b.HasKey("UserlogInId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("SingleDetails");
                });

            modelBuilder.Entity("AuthenticationandAuthorization.Models.Student", b =>
                {
                    b.Property<int>("studentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.HasKey("studentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("AuthenticationandAuthorization.Models.Subcription", b =>
                {
                    b.Property<int>("SubId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<double>("AmountToBePaid");

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("ClientName");

                    b.Property<DateTime?>("ExpireDate");

                    b.Property<int>("MembershipId");

                    b.Property<string>("MembershipName");

                    b.Property<bool>("MorePaymentRequired");

                    b.Property<string>("PaymentDate");

                    b.Property<string>("PaymentMethod");

                    b.Property<double>("RemainingAmount");

                    b.Property<DateTime>("StartDate");

                    b.Property<bool>("Status");

                    b.HasKey("SubId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("MembershipId");

                    b.ToTable("Subcriptions");
                });

            modelBuilder.Entity("AuthenticationandAuthorization.Models.UserDetail", b =>
                {
                    b.Property<int>("UserdetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("UserImageUrl");

                    b.Property<string>("UserName");

                    b.HasKey("UserdetailId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("UserDetail");
                });

            modelBuilder.Entity("AuthenticationandAuthorization.Models.Watchlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("PetId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("PetId");

                    b.ToTable("Watchlists");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("AuthenticationandAuthorization.Models.Membership_Price", b =>
                {
                    b.HasOne("AuthenticationandAuthorization.Models.Membership", "Membership")
                        .WithMany("Membership_Prices")
                        .HasForeignKey("MembershipId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AuthenticationandAuthorization.Models.Message", b =>
                {
                    b.HasOne("AuthenticationandAuthorization.Models.ApplicationUser", "FromUser")
                        .WithMany("Messages")
                        .HasForeignKey("FromUserId");
                });

            modelBuilder.Entity("AuthenticationandAuthorization.Models.NotificationApplicationUser", b =>
                {
                    b.HasOne("AuthenticationandAuthorization.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("NotificationApplicationUsers")
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AuthenticationandAuthorization.Models.Notification", "Notification")
                        .WithMany("NotificationApplicationUsers")
                        .HasForeignKey("NotificationId1")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AuthenticationandAuthorization.Models.Pet", b =>
                {
                    b.HasOne("AuthenticationandAuthorization.Models.ApplicationUser", "User")
                        .WithMany("Pets")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("AuthenticationandAuthorization.Models.SingleDetails", b =>
                {
                    b.HasOne("AuthenticationandAuthorization.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("AuthenticationandAuthorization.Models.Subcription", b =>
                {
                    b.HasOne("AuthenticationandAuthorization.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("AuthenticationandAuthorization.Models.Membership", "Membership")
                        .WithMany("Subcriptions")
                        .HasForeignKey("MembershipId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AuthenticationandAuthorization.Models.UserDetail", b =>
                {
                    b.HasOne("AuthenticationandAuthorization.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("AuthenticationandAuthorization.Models.Watchlist", b =>
                {
                    b.HasOne("AuthenticationandAuthorization.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Watchlists")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("AuthenticationandAuthorization.Models.Pet", "Pet")
                        .WithMany("Watchlists")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AuthenticationandAuthorization.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AuthenticationandAuthorization.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AuthenticationandAuthorization.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AuthenticationandAuthorization.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

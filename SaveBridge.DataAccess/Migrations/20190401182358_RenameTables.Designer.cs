﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SaveBridge.DataAccess.EF;

namespace SaveBridge.DataAccess.Migrations
{
    [DbContext(typeof(SaveBridgeContext))]
    [Migration("20190401182358_RenameTables")]
    partial class RenameTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("SaveBridge.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address");

                    b.Property<Guid>("CityId");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

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

                    b.HasIndex("CityId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("SaveBridge.Entities.Breakdown", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BreakdownPercent");

                    b.Property<Guid>("BuildingConstructionId");

                    b.Property<string>("Reason");

                    b.HasKey("Id");

                    b.HasIndex("BuildingConstructionId");

                    b.ToTable("Breakdowns");
                });

            modelBuilder.Entity("SaveBridge.Entities.BuildingConstruction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<Guid>("BuildingConstructionTypeId");

                    b.Property<Guid?>("CityId");

                    b.Property<Guid>("CountryId");

                    b.Property<double>("CurrentBreakdownPercent");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("BuildingConstructionTypeId");

                    b.HasIndex("CityId");

                    b.ToTable("BuildingConstructions");
                });

            modelBuilder.Entity("SaveBridge.Entities.BuildingConstructionType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("BuildingConstructionTypes");
                });

            modelBuilder.Entity("SaveBridge.Entities.City", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CountryId");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("SaveBridge.Entities.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("SaveBridge.Entities.Pressure", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BuildingConstructionId");

                    b.Property<DateTime>("MeasurementDate");

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.HasIndex("BuildingConstructionId");

                    b.ToTable("Pressures");
                });

            modelBuilder.Entity("SaveBridge.Entities.Renovation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BuildingConstructionId");

                    b.Property<string>("Discription");

                    b.Property<DateTime>("MeasurementDate");

                    b.HasKey("Id");

                    b.HasIndex("BuildingConstructionId");

                    b.ToTable("Renovations");
                });

            modelBuilder.Entity("SaveBridge.Entities.Vibration", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("BuildingConstructionId");

                    b.Property<DateTime>("MeasurementDate");

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.HasIndex("BuildingConstructionId");

                    b.ToTable("Vibrations");
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
                    b.HasOne("SaveBridge.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SaveBridge.Entities.ApplicationUser")
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

                    b.HasOne("SaveBridge.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SaveBridge.Entities.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SaveBridge.Entities.ApplicationUser", b =>
                {
                    b.HasOne("SaveBridge.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SaveBridge.Entities.Breakdown", b =>
                {
                    b.HasOne("SaveBridge.Entities.BuildingConstruction", "BuildingConstruction")
                        .WithMany("Breakdowns")
                        .HasForeignKey("BuildingConstructionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SaveBridge.Entities.BuildingConstruction", b =>
                {
                    b.HasOne("SaveBridge.Entities.BuildingConstructionType", "BuildingConstructionType")
                        .WithMany("BuildingConstructions")
                        .HasForeignKey("BuildingConstructionTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SaveBridge.Entities.City", "City")
                        .WithMany("BuildingConstructions")
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("SaveBridge.Entities.City", b =>
                {
                    b.HasOne("SaveBridge.Entities.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SaveBridge.Entities.Pressure", b =>
                {
                    b.HasOne("SaveBridge.Entities.BuildingConstruction", "BuildingConstruction")
                        .WithMany("Pressures")
                        .HasForeignKey("BuildingConstructionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SaveBridge.Entities.Renovation", b =>
                {
                    b.HasOne("SaveBridge.Entities.BuildingConstruction", "BuildingConstruction")
                        .WithMany("Renovations")
                        .HasForeignKey("BuildingConstructionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SaveBridge.Entities.Vibration", b =>
                {
                    b.HasOne("SaveBridge.Entities.BuildingConstruction", "BuildingConstruction")
                        .WithMany("Vibrations")
                        .HasForeignKey("BuildingConstructionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

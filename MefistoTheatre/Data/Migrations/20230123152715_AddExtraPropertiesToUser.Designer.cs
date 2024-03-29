﻿// <auto-generated />
using System;
using MefistoTheatre.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MefistoTheatre.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230123152715_AddExtraPropertiesToUser")]
    partial class AddExtraPropertiesToUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MefistoTheatre.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSuspended")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Joined")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "479495d1-fed1-44c0-815e-b31f497ad74b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f867fac8-3925-4c38-a653-76edff81a242",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@mefisto.com",
                            EmailConfirmed = true,
                            IsSuspended = false,
                            Joined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MEFISTO.COM",
                            NormalizedUserName = "ADMIN@MEFISTO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPfz8NAmescxj/khN76+WgHEOP73VOsfZeASkh/T3E/0CIdF/VUjj9EBf9u9iC5lfw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c138288d-ef76-41d8-bc4a-4ea89115bb5f",
                            TwoFactorEnabled = false,
                            UserName = "admin@mefisto.com"
                        },
                        new
                        {
                            Id = "fb7f21ce-7887-4fea-aeba-bb0dceed54d5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "59e4c71c-e17d-4866-820a-da46f8981d0d",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "editor@mefisto.com",
                            EmailConfirmed = true,
                            IsSuspended = false,
                            Joined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LockoutEnabled = false,
                            NormalizedEmail = "EDITOR@MEFISTO.COM",
                            NormalizedUserName = "EDITOR@MEFISTO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGzQnYGTel+71r63ALHkav8Ks5qu7hlkLqHjoMo3weOHSNLuy2+9pp0dfE4OGqLQRA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c96511eb-87e7-4914-a961-6303d2441177",
                            TwoFactorEnabled = false,
                            UserName = "editor@mefisto.com"
                        },
                        new
                        {
                            Id = "41eacba3-57a0-435d-a8f9-d17bfb24f196",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "03d44289-1223-4a17-808b-6e9e7b449daa",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "staff@mefisto.com",
                            EmailConfirmed = true,
                            IsSuspended = false,
                            Joined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF@MEFISTO.COM",
                            NormalizedUserName = "STAFF@MEFISTO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJhrPpXrW4q+VeY/0f5+oSWSvdgaRkLJwlhmLHo0IwCLqy0TPCRmvNDX5dM2mDcpVw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "acf3efa5-a85b-41c5-9f76-8a538e5fdda6",
                            TwoFactorEnabled = false,
                            UserName = "staff@mefisto.com"
                        },
                        new
                        {
                            Id = "c76cb229-9706-4cba-a40b-8fbcc8d331a4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b5a6848b-152d-4a60-bb1c-86a198180f1d",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "basic@basic.com",
                            EmailConfirmed = true,
                            IsSuspended = false,
                            Joined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LockoutEnabled = false,
                            NormalizedEmail = "BASIC@BASIC.COM",
                            NormalizedUserName = "BASIC@BASIC.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDj/B1ZniMWD6tEWpKUJgKB3iSB6mfQ9nxRmQ7qf8L7U6eR1uaPCx0uDWT9VGnP4Mw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "87715852-f555-47d9-8bd9-f393f2e5a620",
                            TwoFactorEnabled = false,
                            UserName = "basic@basic.com"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "5a0946d0-3d3a-474d-a1fb-533cab858ef1",
                            ConcurrencyStamp = "dc05d160-e419-4c27-81f7-62feb4a607eb",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "ea1c9ea8-2daf-41fe-88b9-0d17f6734611",
                            ConcurrencyStamp = "27d9edbf-5abf-41d3-a891-8cb1f182c4b9",
                            Name = "Editor",
                            NormalizedName = "EDITOR"
                        },
                        new
                        {
                            Id = "66c56718-3786-423e-bed3-86b953765100",
                            ConcurrencyStamp = "a73e20de-d9d9-4783-838c-5e05d4fa1d33",
                            Name = "Staff",
                            NormalizedName = "STAFF"
                        },
                        new
                        {
                            Id = "76177bf1-4358-4f3b-a851-28a666064fcf",
                            ConcurrencyStamp = "761eb475-9be4-44a1-8c34-eb6aa685180c",
                            Name = "Basic",
                            NormalizedName = "BASIC"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "479495d1-fed1-44c0-815e-b31f497ad74b",
                            RoleId = "5a0946d0-3d3a-474d-a1fb-533cab858ef1"
                        },
                        new
                        {
                            UserId = "fb7f21ce-7887-4fea-aeba-bb0dceed54d5",
                            RoleId = "ea1c9ea8-2daf-41fe-88b9-0d17f6734611"
                        },
                        new
                        {
                            UserId = "41eacba3-57a0-435d-a8f9-d17bfb24f196",
                            RoleId = "66c56718-3786-423e-bed3-86b953765100"
                        },
                        new
                        {
                            UserId = "c76cb229-9706-4cba-a40b-8fbcc8d331a4",
                            RoleId = "76177bf1-4358-4f3b-a851-28a666064fcf"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MefistoTheatre.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MefistoTheatre.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MefistoTheatre.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MefistoTheatre.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

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
    [Migration("20230216185058_fix-cascade")]
    partial class fixcascade
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
                            Id = "bfd81596-d4c7-4236-9112-1dab11048210",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b40e8b99-7c8c-47e8-9e3e-8834e8ddcf88",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@mefisto.com",
                            EmailConfirmed = true,
                            IsSuspended = false,
                            Joined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MEFISTO.COM",
                            NormalizedUserName = "ADMIN@MEFISTO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEKhVUn8xw2Dy+MfACGjSviN3r7mQOn9YXSL6JW1wx9G1+g3bHpeGYiJG1NPQxU8K4g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1c0ff3a1-80d4-4282-baab-f6613644997e",
                            TwoFactorEnabled = false,
                            UserName = "admin@mefisto.com"
                        },
                        new
                        {
                            Id = "77e8fe47-ad47-44b9-8fe7-d7398f98c80e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9a5b9e3e-c3a6-4795-853f-145a20aaeab6",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "editor@mefisto.com",
                            EmailConfirmed = true,
                            IsSuspended = false,
                            Joined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LockoutEnabled = false,
                            NormalizedEmail = "EDITOR@MEFISTO.COM",
                            NormalizedUserName = "EDITOR@MEFISTO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEMc2GKulKYn6wR6h0/LGvuXQvj9mJIpunZTA0Oe6TxjUM3v+qtDzqUlZjNCJfOrXyA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e55257ba-ba42-445c-8d99-bed3a4c59fa2",
                            TwoFactorEnabled = false,
                            UserName = "editor@mefisto.com"
                        },
                        new
                        {
                            Id = "39738235-8493-453a-abea-2573efe727c4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6dc48fd0-cb43-4247-935d-448ececf6ffc",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "staff@mefisto.com",
                            EmailConfirmed = true,
                            IsSuspended = false,
                            Joined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LockoutEnabled = false,
                            NormalizedEmail = "STAFF@MEFISTO.COM",
                            NormalizedUserName = "STAFF@MEFISTO.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPmoCw/KrkQHB5MW2623ybwN1iuOeQrku2JlqfrLAsx2vwQovXbb8eHSMgeqAyvJpA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "281b6051-f9f1-49f3-9e43-4d6d5f8e00a9",
                            TwoFactorEnabled = false,
                            UserName = "staff@mefisto.com"
                        },
                        new
                        {
                            Id = "634824c3-1db4-4c59-af21-80267fa7ae00",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d546ed70-5df3-45ae-a008-1445848975f2",
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "basic@basic.com",
                            EmailConfirmed = true,
                            IsSuspended = false,
                            Joined = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LockoutEnabled = false,
                            NormalizedEmail = "BASIC@BASIC.COM",
                            NormalizedUserName = "BASIC@BASIC.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEOTdtgxZdhxLB9tSnZF3B8Yo+nPEiPfDIxgpN1lQQbcEzbEczy0jnnAVSo+3DqSG2w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3f700215-bf2b-4422-90d9-71305dbdc84d",
                            TwoFactorEnabled = false,
                            UserName = "basic@basic.com"
                        });
                });

            modelBuilder.Entity("MefistoTheatre.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "42b7c00a-47e7-406e-9842-5b85abc26f75",
                            CategoryName = "Review"
                        },
                        new
                        {
                            CategoryId = "de0256b1-9592-49f9-a33e-87b10fd5da20",
                            CategoryName = "Interview"
                        },
                        new
                        {
                            CategoryId = "264cc9f6-718e-422b-9233-c011ca3f12b0",
                            CategoryName = "Announcements"
                        },
                        new
                        {
                            CategoryId = "a7df97b7-2a7a-4a42-99ea-ff8221ee2eb3",
                            CategoryName = "Features"
                        });
                });

            modelBuilder.Entity("MefistoTheatre.Models.Comment", b =>
                {
                    b.Property<string>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<DateTime>("PublishedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PostId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("MefistoTheatre.Models.Post", b =>
                {
                    b.Property<string>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("PublishedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PostId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");
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
                            Id = "11954cc1-242b-46be-a16c-0c8a1db982ea",
                            ConcurrencyStamp = "cc424228-edb2-43f5-b1c6-62cd39f7cfdd",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "6df28832-7c96-4e04-96a0-0cda4e2bba0b",
                            ConcurrencyStamp = "9314d068-4a43-4244-8381-6b6b45e20576",
                            Name = "Editor",
                            NormalizedName = "EDITOR"
                        },
                        new
                        {
                            Id = "33d6329f-cd13-4929-90d2-0a3c8015e78e",
                            ConcurrencyStamp = "97488b4e-387b-40e6-9976-c3d6dff9909b",
                            Name = "Staff",
                            NormalizedName = "STAFF"
                        },
                        new
                        {
                            Id = "9216d8dc-d1cb-4768-946b-a6aae076b053",
                            ConcurrencyStamp = "74478cd8-8451-434e-8cfe-54b630b465c3",
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
                            UserId = "bfd81596-d4c7-4236-9112-1dab11048210",
                            RoleId = "11954cc1-242b-46be-a16c-0c8a1db982ea"
                        },
                        new
                        {
                            UserId = "77e8fe47-ad47-44b9-8fe7-d7398f98c80e",
                            RoleId = "6df28832-7c96-4e04-96a0-0cda4e2bba0b"
                        },
                        new
                        {
                            UserId = "39738235-8493-453a-abea-2573efe727c4",
                            RoleId = "33d6329f-cd13-4929-90d2-0a3c8015e78e"
                        },
                        new
                        {
                            UserId = "634824c3-1db4-4c59-af21-80267fa7ae00",
                            RoleId = "9216d8dc-d1cb-4768-946b-a6aae076b053"
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

            modelBuilder.Entity("MefistoTheatre.Models.Comment", b =>
                {
                    b.HasOne("MefistoTheatre.Models.ApplicationUser", "Author")
                        .WithMany("Comments")
                        .HasForeignKey("AuthorId");

                    b.HasOne("MefistoTheatre.Models.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("MefistoTheatre.Models.Post", b =>
                {
                    b.HasOne("MefistoTheatre.Models.ApplicationUser", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("AuthorId");

                    b.HasOne("MefistoTheatre.Models.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Author");

                    b.Navigation("Category");
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

            modelBuilder.Entity("MefistoTheatre.Models.ApplicationUser", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("MefistoTheatre.Models.Category", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("MefistoTheatre.Models.Post", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}

using MefistoTheatre.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MefistoTheatre.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Create roles.
            List<IdentityRole> roles = new List<IdentityRole>()
            {
                new IdentityRole {Name = "Admin", NormalizedName = "ADMIN"},
                new IdentityRole {Name = "Editor", NormalizedName = "EDITOR"},
                new IdentityRole {Name = "Staff", NormalizedName = "STAFF"},
                new IdentityRole {Name = "Basic", NormalizedName = "BASIC"}
            };

            modelBuilder.Entity<IdentityRole>().HasData(roles);

            // Create users.
            List<ApplicationUser> users = new List<ApplicationUser>
            {
                new ApplicationUser
                {
                    UserName = "admin@mefisto.com",
                    NormalizedUserName = "ADMIN@MEFISTO.COM",
                    Email = "admin@mefisto.com",
                    NormalizedEmail = "ADMIN@MEFISTO.COM",
                    EmailConfirmed = true,
                },
                new ApplicationUser
                {
                    UserName = "editor@mefisto.com",
                    NormalizedUserName = "EDITOR@MEFISTO.COM",
                    Email = "editor@mefisto.com",
                    NormalizedEmail = "EDITOR@MEFISTO.COM",
                    EmailConfirmed = true,
                },
                new ApplicationUser
                {
                    UserName = "staff@mefisto.com",
                    NormalizedUserName = "STAFF@MEFISTO.COM",
                    Email = "staff@mefisto.com",
                    NormalizedEmail = "STAFF@MEFISTO.COM",
                    EmailConfirmed = true,
                },
                new ApplicationUser
                {
                    UserName = "basic@basic.com",
                    NormalizedUserName = "BASIC@BASIC.COM",
                    Email = "basic@basic.com",
                    NormalizedEmail = "BASIC@BASIC.COM",
                    EmailConfirmed = true,
                }
            };

            modelBuilder.Entity<ApplicationUser>().HasData(users);

            // Add hashed passwords to the users.
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            users[0].PasswordHash = passwordHasher.HashPassword(users[0], "Admin123!");
            users[1].PasswordHash = passwordHasher.HashPassword(users[1], "Editor123!");
            users[2].PasswordHash = passwordHasher.HashPassword(users[2], "Staff123!");
            users[3].PasswordHash = passwordHasher.HashPassword(users[3], "Basic123!");

            // Add the user to their role.
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();

            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[0].Id,
                RoleId = roles.First(r => r.Name == "Admin").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[1].Id,
                RoleId = roles.First(r => r.Name == "Editor").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[2].Id,
                RoleId = roles.First(r => r.Name == "Staff").Id
            });
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[3].Id,
                RoleId = roles.First(r => r.Name == "Basic").Id
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);

            List<Category> categories = new List<Category>();

            categories.Add(new Category
            {
                CategoryId = Guid.NewGuid().ToString(),
                CategoryName = "Review"
            }
            );
            categories.Add(new Category
            {
                CategoryId = Guid.NewGuid().ToString(),
                CategoryName = "Interview"
            }
            );
            categories.Add(new Category
            {
                CategoryId = Guid.NewGuid().ToString(),
                CategoryName = "Announcements"
            }
            );
            categories.Add(new Category
            {
                CategoryId = Guid.NewGuid().ToString(),
                CategoryName = "Features"
            }
            );

            modelBuilder.Entity<Category>().HasData(categories);
        }
    }
}

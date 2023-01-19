using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MefistoTheatre.Data.Migrations
{
    public partial class SeedUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "070b7596-c5f5-4866-80d6-30b5743c35fd", "f292133f-e0c7-47e2-a5fd-5e3cb29f1611", "Basic", "BASIC" },
                    { "2f4eae13-3357-42fb-8653-b71ea140f8f1", "6a184501-9158-4a18-92c5-4284c1a16e7d", "Admin", "ADMIN" },
                    { "30decc32-1c97-4b6d-a03e-34b5f322e05e", "6ffad12c-d3ae-4370-8ea9-7dc6c6176848", "SuperAdmin", "SUPERADMIN" },
                    { "dc93dd4b-5dec-44e8-804e-af814eed1cd4", "b1d94f00-bb63-4c29-af37-a5d3acfbc99a", "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3cd42b78-ade8-4151-af9e-0f18a629faec", 0, "4bec9f3c-dbc1-48fb-98e8-a4a4651942d3", "admin@mefisto.com", true, null, null, false, null, "ADMIN@MEFISTO.COM", "ADMIN@MEFISTO.COM", "AQAAAAEAACcQAAAAEOnVkq1hSRiojXER45WA6i56idqtPCxLJcoU1bsP8+PnR+KMnhISYp+zEXQdAXs2hQ==", null, false, "310cc357-7129-415e-8587-35a0db1084f0", false, "admin@mefisto.com" },
                    { "632c02a3-f309-479a-97b8-613906884c8a", 0, "676ad9f2-2ca5-4835-a2ac-3d4ca48d8566", "superadmin@mefisto.com", true, null, null, false, null, "SUPERADMIN@MEFISTO.COM", "SUPERADMIN@MEFISTO.COM", "AQAAAAEAACcQAAAAEMH28Rl2yIVinshZCyJ6xTHeAnD9p0rlRREGKrrsaufZVOdKErMqi+JqzWmMo+TzGw==", null, false, "26e2ce47-abb0-4933-b996-8db5576f30d8", false, "superadmin@mefisto.com" },
                    { "83eac18f-647a-4400-94c7-87caa344cb67", 0, "dc880794-dbf6-42f3-8979-2dc6b60c7313", "staff@mefisto.com", true, null, null, false, null, "STAFF@MEFISTO.COM", "STAFF@MEFISTO.COM", "AQAAAAEAACcQAAAAEIVLMg2zhTbXbbAQoojWi0Z9pJLLATOYi4wjThHBJ1sff6gid30pyv/QyeNNlTWGuQ==", null, false, "cef31a8b-68e8-4f12-8b5a-dfdbbbd8f6c0", false, "staff@mefisto.com" },
                    { "9f9762a2-1caf-425f-8497-9b97776e725e", 0, "920b31ab-b262-45fe-a009-6c88939fecab", "basic@basic.com", true, null, null, false, null, "BASIC@BASIC.COM", "BASIC@BASIC.COM", "AQAAAAEAACcQAAAAECJrBa6OvtuS9fHlx8rmNG7RM0nwOi9hbmLo4dqEQ0qWsiMIHMDVAvt3z+GtAv8mOA==", null, false, "a03dc394-e300-484f-88f5-a2f21a47bd1e", false, "basic@basic.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2f4eae13-3357-42fb-8653-b71ea140f8f1", "3cd42b78-ade8-4151-af9e-0f18a629faec" },
                    { "30decc32-1c97-4b6d-a03e-34b5f322e05e", "632c02a3-f309-479a-97b8-613906884c8a" },
                    { "dc93dd4b-5dec-44e8-804e-af814eed1cd4", "83eac18f-647a-4400-94c7-87caa344cb67" },
                    { "070b7596-c5f5-4866-80d6-30b5743c35fd", "9f9762a2-1caf-425f-8497-9b97776e725e" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f4eae13-3357-42fb-8653-b71ea140f8f1", "3cd42b78-ade8-4151-af9e-0f18a629faec" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "30decc32-1c97-4b6d-a03e-34b5f322e05e", "632c02a3-f309-479a-97b8-613906884c8a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dc93dd4b-5dec-44e8-804e-af814eed1cd4", "83eac18f-647a-4400-94c7-87caa344cb67" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "070b7596-c5f5-4866-80d6-30b5743c35fd", "9f9762a2-1caf-425f-8497-9b97776e725e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "070b7596-c5f5-4866-80d6-30b5743c35fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f4eae13-3357-42fb-8653-b71ea140f8f1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30decc32-1c97-4b6d-a03e-34b5f322e05e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc93dd4b-5dec-44e8-804e-af814eed1cd4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3cd42b78-ade8-4151-af9e-0f18a629faec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "632c02a3-f309-479a-97b8-613906884c8a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83eac18f-647a-4400-94c7-87caa344cb67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f9762a2-1caf-425f-8497-9b97776e725e");
        }
    }
}

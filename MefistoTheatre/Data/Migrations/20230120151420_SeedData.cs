using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MefistoTheatre.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5ac28e47-e0da-457d-b4c4-280ce73e08e1", "00b7f372-7892-4cb4-9718-2835e91ca584", "Admin", "ADMIN" },
                    { "a98cc1f1-ac15-404a-a01b-518b012eaa8b", "0b7ccbea-80eb-4d0c-a71b-4731b593dfef", "Basic", "BASIC" },
                    { "bbb48dfb-0d0b-48e1-a299-3adcaa3e7ce9", "18e26552-1924-429d-9a8c-6b5a782b7664", "Staff", "STAFF" },
                    { "be539ba6-e42a-4fe8-933b-aa1ffe68162c", "bef6dd52-33dc-4e55-89ed-2bf1125c7365", "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5c725ddb-54c0-4f09-8382-d0c00196bb3a", 0, "6cc9b453-a5e3-4bbe-bbdc-2d1ba5f027b7", "staff@mefisto.com", true, null, null, false, null, "STAFF@MEFISTO.COM", "STAFF@MEFISTO.COM", "AQAAAAEAACcQAAAAEES3Q6K9m9etfeeq1WR5NRKZqfzj6yacTyiC0tdHnupJkR/8VQVuKLvOTEcatqvCrw==", null, false, "0ed5b109-54ba-4354-81ed-d47ef530ee09", false, "staff@mefisto.com" },
                    { "ebb7e8be-5379-498a-baef-9d589bb18fbe", 0, "d4ee4d44-8106-43e7-bd06-2bb248e85970", "editor@mefisto.com", true, null, null, false, null, "EDITOR@MEFISTO.COM", "EDITOR@MEFISTO.COM", "AQAAAAEAACcQAAAAEFeGLZ+JA4nkSPDkfj2qn3hUS/JOPj8e3brQHs/WWIQA47HXYBogDgvCSPJhDzjBpQ==", null, false, "f1db8ba4-df9c-461d-8251-b86f6926cfdf", false, "editor@mefisto.com" },
                    { "fa4315ef-cfaf-4c49-a22c-f46d9e3a2529", 0, "2dc46547-0d8a-48b7-97bb-259b7cc44f21", "basic@basic.com", true, null, null, false, null, "BASIC@BASIC.COM", "BASIC@BASIC.COM", "AQAAAAEAACcQAAAAECD1TteiXvQAB4WXDEFJJxm/nEgsEUFXtFailTFulFtWFKgqT4yhoR1qI47Nk72lDw==", null, false, "6e66e615-4283-45a4-9051-97020ef52925", false, "basic@basic.com" },
                    { "fc3eb3b0-d95e-4172-8338-3cfa6ad1239b", 0, "ebee6c8e-d1dd-4241-ba9e-c0e8191257a5", "admin@mefisto.com", true, null, null, false, null, "ADMIN@MEFISTO.COM", "ADMIN@MEFISTO.COM", "AQAAAAEAACcQAAAAEBaAK8z7h2t2que29xzGyHSdZYDV/WHUMMw3Rs+AeP+sVnS3wnJlWcv2fP175Yjf8g==", null, false, "c8dab608-5e9e-4d66-b894-48e7ce33bd70", false, "admin@mefisto.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bbb48dfb-0d0b-48e1-a299-3adcaa3e7ce9", "5c725ddb-54c0-4f09-8382-d0c00196bb3a" },
                    { "be539ba6-e42a-4fe8-933b-aa1ffe68162c", "ebb7e8be-5379-498a-baef-9d589bb18fbe" },
                    { "a98cc1f1-ac15-404a-a01b-518b012eaa8b", "fa4315ef-cfaf-4c49-a22c-f46d9e3a2529" },
                    { "5ac28e47-e0da-457d-b4c4-280ce73e08e1", "fc3eb3b0-d95e-4172-8338-3cfa6ad1239b" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bbb48dfb-0d0b-48e1-a299-3adcaa3e7ce9", "5c725ddb-54c0-4f09-8382-d0c00196bb3a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "be539ba6-e42a-4fe8-933b-aa1ffe68162c", "ebb7e8be-5379-498a-baef-9d589bb18fbe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a98cc1f1-ac15-404a-a01b-518b012eaa8b", "fa4315ef-cfaf-4c49-a22c-f46d9e3a2529" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5ac28e47-e0da-457d-b4c4-280ce73e08e1", "fc3eb3b0-d95e-4172-8338-3cfa6ad1239b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ac28e47-e0da-457d-b4c4-280ce73e08e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a98cc1f1-ac15-404a-a01b-518b012eaa8b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bbb48dfb-0d0b-48e1-a299-3adcaa3e7ce9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be539ba6-e42a-4fe8-933b-aa1ffe68162c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c725ddb-54c0-4f09-8382-d0c00196bb3a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ebb7e8be-5379-498a-baef-9d589bb18fbe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa4315ef-cfaf-4c49-a22c-f46d9e3a2529");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc3eb3b0-d95e-4172-8338-3cfa6ad1239b");
        }
    }
}

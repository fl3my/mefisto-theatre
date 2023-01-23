using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MefistoTheatre.Data.Migrations
{
    public partial class AddExtraPropertiesToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsSuspended",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Joined",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PostCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5a0946d0-3d3a-474d-a1fb-533cab858ef1", "dc05d160-e419-4c27-81f7-62feb4a607eb", "Admin", "ADMIN" },
                    { "66c56718-3786-423e-bed3-86b953765100", "a73e20de-d9d9-4783-838c-5e05d4fa1d33", "Staff", "STAFF" },
                    { "76177bf1-4358-4f3b-a851-28a666064fcf", "761eb475-9be4-44a1-8c34-eb6aa685180c", "Basic", "BASIC" },
                    { "ea1c9ea8-2daf-41fe-88b9-0d17f6734611", "27d9edbf-5abf-41d3-a891-8cb1f182c4b9", "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "IsSuspended", "Joined", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "41eacba3-57a0-435d-a8f9-d17bfb24f196", 0, null, null, "03d44289-1223-4a17-808b-6e9e7b449daa", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "STAFF@MEFISTO.COM", "STAFF@MEFISTO.COM", "AQAAAAEAACcQAAAAEJhrPpXrW4q+VeY/0f5+oSWSvdgaRkLJwlhmLHo0IwCLqy0TPCRmvNDX5dM2mDcpVw==", null, false, null, "acf3efa5-a85b-41c5-9f76-8a538e5fdda6", false, "staff@mefisto.com" },
                    { "479495d1-fed1-44c0-815e-b31f497ad74b", 0, null, null, "f867fac8-3925-4c38-a653-76edff81a242", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "ADMIN@MEFISTO.COM", "ADMIN@MEFISTO.COM", "AQAAAAEAACcQAAAAEPfz8NAmescxj/khN76+WgHEOP73VOsfZeASkh/T3E/0CIdF/VUjj9EBf9u9iC5lfw==", null, false, null, "c138288d-ef76-41d8-bc4a-4ea89115bb5f", false, "admin@mefisto.com" },
                    { "c76cb229-9706-4cba-a40b-8fbcc8d331a4", 0, null, null, "b5a6848b-152d-4a60-bb1c-86a198180f1d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic@basic.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "BASIC@BASIC.COM", "BASIC@BASIC.COM", "AQAAAAEAACcQAAAAEDj/B1ZniMWD6tEWpKUJgKB3iSB6mfQ9nxRmQ7qf8L7U6eR1uaPCx0uDWT9VGnP4Mw==", null, false, null, "87715852-f555-47d9-8bd9-f393f2e5a620", false, "basic@basic.com" },
                    { "fb7f21ce-7887-4fea-aeba-bb0dceed54d5", 0, null, null, "59e4c71c-e17d-4866-820a-da46f8981d0d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "editor@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "EDITOR@MEFISTO.COM", "EDITOR@MEFISTO.COM", "AQAAAAEAACcQAAAAEGzQnYGTel+71r63ALHkav8Ks5qu7hlkLqHjoMo3weOHSNLuy2+9pp0dfE4OGqLQRA==", null, false, null, "c96511eb-87e7-4914-a961-6303d2441177", false, "editor@mefisto.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "66c56718-3786-423e-bed3-86b953765100", "41eacba3-57a0-435d-a8f9-d17bfb24f196" },
                    { "5a0946d0-3d3a-474d-a1fb-533cab858ef1", "479495d1-fed1-44c0-815e-b31f497ad74b" },
                    { "76177bf1-4358-4f3b-a851-28a666064fcf", "c76cb229-9706-4cba-a40b-8fbcc8d331a4" },
                    { "ea1c9ea8-2daf-41fe-88b9-0d17f6734611", "fb7f21ce-7887-4fea-aeba-bb0dceed54d5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "66c56718-3786-423e-bed3-86b953765100", "41eacba3-57a0-435d-a8f9-d17bfb24f196" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5a0946d0-3d3a-474d-a1fb-533cab858ef1", "479495d1-fed1-44c0-815e-b31f497ad74b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "76177bf1-4358-4f3b-a851-28a666064fcf", "c76cb229-9706-4cba-a40b-8fbcc8d331a4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ea1c9ea8-2daf-41fe-88b9-0d17f6734611", "fb7f21ce-7887-4fea-aeba-bb0dceed54d5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a0946d0-3d3a-474d-a1fb-533cab858ef1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66c56718-3786-423e-bed3-86b953765100");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76177bf1-4358-4f3b-a851-28a666064fcf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ea1c9ea8-2daf-41fe-88b9-0d17f6734611");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41eacba3-57a0-435d-a8f9-d17bfb24f196");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "479495d1-fed1-44c0-815e-b31f497ad74b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c76cb229-9706-4cba-a40b-8fbcc8d331a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb7f21ce-7887-4fea-aeba-bb0dceed54d5");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsSuspended",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Joined",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PostCode",
                table: "AspNetUsers");

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
    }
}

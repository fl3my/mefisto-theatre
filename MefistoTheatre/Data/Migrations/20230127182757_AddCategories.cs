using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MefistoTheatre.Data.Migrations
{
    public partial class AddCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0859d60b-f6f8-4720-b93f-5a0e64f173e9", "5b0be16f-8e6c-4762-a79f-0c53b743f760", "Editor", "EDITOR" },
                    { "16509ca9-c900-41f0-82a1-1dc1e0d0498f", "bfd0ab21-d287-45ff-8321-85f899ae156a", "Staff", "STAFF" },
                    { "7085368f-3b0c-44cb-b427-a33353905e9a", "4bb4c272-2451-4e1d-ac50-e7759ac5e83b", "Admin", "ADMIN" },
                    { "8ae887b0-0d79-4434-b00d-9d76eb79de3e", "85e66b67-c6e0-4861-b543-cb658e806f37", "Basic", "BASIC" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "IsSuspended", "Joined", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1f75cd59-fc01-4a37-a91f-1c58cbd72fc8", 0, null, null, "c710c4b8-9426-4bc9-8dd2-d2b24cbb09ad", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic@basic.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "BASIC@BASIC.COM", "BASIC@BASIC.COM", "AQAAAAEAACcQAAAAEJXvjU0TYv+Jq8oOGMDPQB5X+ag45xZ7fjVqLbGD097byOUQ0TEsivG5qny9rQiwAA==", null, false, null, "4ac1c8b9-b7a4-4719-8252-7b4614c3f1f0", false, "basic@basic.com" },
                    { "c2dacaff-2873-4bba-b6fc-b21ba5cfa209", 0, null, null, "04c7cdd9-ba02-4318-b21a-f800e8159cc8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "ADMIN@MEFISTO.COM", "ADMIN@MEFISTO.COM", "AQAAAAEAACcQAAAAEEmHgc4F2fTfnd2C1deOh7kRJT2YbyQyi2WyMfRcQp6coS2DNOfXgBX3TCE/ye5yVA==", null, false, null, "8116edb7-1739-4ed1-babf-dd8cfb94ca2c", false, "admin@mefisto.com" },
                    { "c73a2d66-d8f4-4afc-b656-305519a22f0e", 0, null, null, "ec6560ba-f55a-451f-aeaf-6d9a6c8c7fb8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "STAFF@MEFISTO.COM", "STAFF@MEFISTO.COM", "AQAAAAEAACcQAAAAEKr3PtI4IZF93HYnZ9oVfqJ/07psUjW35gu9r50Mt8Zghmlv7AUZSbVodvDFdvjFLQ==", null, false, null, "36a49a42-f9ae-404c-976b-e7ba0e2b22ab", false, "staff@mefisto.com" },
                    { "ecc09658-0e74-4f54-95ef-2b3e471e00d4", 0, null, null, "48ded2db-9ecd-41bb-a6db-53511b80da34", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "editor@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "EDITOR@MEFISTO.COM", "EDITOR@MEFISTO.COM", "AQAAAAEAACcQAAAAED95dGSijMVqBz/VL86k75EyHnjmGM7+zcaPxep/wM56IwOK616FPFpJxC0iY+BUVw==", null, false, null, "531a0e2e-c51f-4aed-b679-7ce9f81f648d", false, "editor@mefisto.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "5a8ab78e-d3cf-4260-8d8e-a9f492161dd1", "Features" },
                    { "5fbe6711-7e3f-427a-9201-81b54df6c996", "Review" },
                    { "bff3288d-1a36-4ec7-bf3b-b055b38cea9f", "Interview" },
                    { "e464f7e0-70cc-406e-8940-0536034f7de8", "Announcements" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8ae887b0-0d79-4434-b00d-9d76eb79de3e", "1f75cd59-fc01-4a37-a91f-1c58cbd72fc8" },
                    { "7085368f-3b0c-44cb-b427-a33353905e9a", "c2dacaff-2873-4bba-b6fc-b21ba5cfa209" },
                    { "16509ca9-c900-41f0-82a1-1dc1e0d0498f", "c73a2d66-d8f4-4afc-b656-305519a22f0e" },
                    { "0859d60b-f6f8-4720-b93f-5a0e64f173e9", "ecc09658-0e74-4f54-95ef-2b3e471e00d4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8ae887b0-0d79-4434-b00d-9d76eb79de3e", "1f75cd59-fc01-4a37-a91f-1c58cbd72fc8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7085368f-3b0c-44cb-b427-a33353905e9a", "c2dacaff-2873-4bba-b6fc-b21ba5cfa209" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "16509ca9-c900-41f0-82a1-1dc1e0d0498f", "c73a2d66-d8f4-4afc-b656-305519a22f0e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0859d60b-f6f8-4720-b93f-5a0e64f173e9", "ecc09658-0e74-4f54-95ef-2b3e471e00d4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0859d60b-f6f8-4720-b93f-5a0e64f173e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16509ca9-c900-41f0-82a1-1dc1e0d0498f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7085368f-3b0c-44cb-b427-a33353905e9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ae887b0-0d79-4434-b00d-9d76eb79de3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f75cd59-fc01-4a37-a91f-1c58cbd72fc8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2dacaff-2873-4bba-b6fc-b21ba5cfa209");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c73a2d66-d8f4-4afc-b656-305519a22f0e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ecc09658-0e74-4f54-95ef-2b3e471e00d4");

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
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MefistoTheatre.Data.Migrations
{
    public partial class AddRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "5a8ab78e-d3cf-4260-8d8e-a9f492161dd1");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "5fbe6711-7e3f-427a-9201-81b54df6c996");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "bff3288d-1a36-4ec7-bf3b-b055b38cea9f");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "e464f7e0-70cc-406e-8940-0536034f7de8");

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

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comment_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3973fd72-3bc2-42ee-821a-7bd486f04baf", "6bbd6d4b-d2c5-4a3d-a8fd-1154a9d1b9e0", "Staff", "STAFF" },
                    { "6e076e4b-71ee-425c-af7f-42b0f2d20d18", "0b2f5f5e-fe9d-4e1f-902d-3a5e85bb8698", "Basic", "BASIC" },
                    { "8363f261-44e0-446d-85d0-12fe94b70305", "dce192ba-26a0-4c94-8d24-7e9702f9584f", "Admin", "ADMIN" },
                    { "b0b6aaf7-7cb8-46c0-8d9b-9bc33b74a18b", "6e66464a-2e35-4667-be0a-cbb4b33c62c5", "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "IsSuspended", "Joined", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "168bcb6a-32c3-4db3-b15f-2dc8a94215ee", 0, null, null, "7485a566-9360-4cde-a3fc-c193a6a59cf1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "STAFF@MEFISTO.COM", "STAFF@MEFISTO.COM", "AQAAAAEAACcQAAAAEBSExeJCxOIWpP3T802Y+p9AxfThEgahr/UR4mtGvufddl43MTO5LkcHnNpS8AxOeQ==", null, false, null, "718db0f3-ce4f-4b97-bb6e-a1ebdd8f7043", false, "staff@mefisto.com" },
                    { "6580cc12-7cd9-4682-84df-1947aa823a11", 0, null, null, "a1b17a12-5ef9-4891-bfc5-585295a52a09", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "ADMIN@MEFISTO.COM", "ADMIN@MEFISTO.COM", "AQAAAAEAACcQAAAAECs4isNK55yHfKrfJ8ZRfWFMVW9oR61WrSUJzE5QEOR8+EIivtWr08l7Ez+CQhU3xA==", null, false, null, "e7540e97-1cb3-4763-b8e0-808fc5c18ee2", false, "admin@mefisto.com" },
                    { "abd8eb1f-a799-45e6-9188-22e3f3e74dcd", 0, null, null, "fd6a6453-00c0-4f0e-8132-e7e4f06b1a3a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic@basic.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "BASIC@BASIC.COM", "BASIC@BASIC.COM", "AQAAAAEAACcQAAAAEKbLcBhjczBxxawPLzxO4IITaIRGaxasEeN+RWVD/u/rVpwq+X5Tga4fptsujy1bFQ==", null, false, null, "60433833-fa71-4759-a372-cca60ff7e30b", false, "basic@basic.com" },
                    { "d7f7e683-6bfc-4aa5-9430-0e20c9c37d5f", 0, null, null, "13dae04f-9a2d-407b-9b5b-ac6ad3353e28", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "editor@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "EDITOR@MEFISTO.COM", "EDITOR@MEFISTO.COM", "AQAAAAEAACcQAAAAEC9Ux4rrCmMSXtk8o3/np/zmPeNypgNvdpbKjMJhabNq7Twc79zeAXczgCfzXDDy2A==", null, false, null, "a46779a0-a45f-470f-b9e0-20a2e62b7f71", false, "editor@mefisto.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "61bc3a32-d1eb-499e-910a-fa7699edad6d", "Interview" },
                    { "819aa564-88f1-4834-97b6-3aab82e01933", "Announcements" },
                    { "90787e3b-d784-4c33-ae07-c16815daf510", "Review" },
                    { "c64affb2-1891-47d4-85b6-7f3023a9308a", "Features" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "3973fd72-3bc2-42ee-821a-7bd486f04baf", "168bcb6a-32c3-4db3-b15f-2dc8a94215ee" },
                    { "8363f261-44e0-446d-85d0-12fe94b70305", "6580cc12-7cd9-4682-84df-1947aa823a11" },
                    { "6e076e4b-71ee-425c-af7f-42b0f2d20d18", "abd8eb1f-a799-45e6-9188-22e3f3e74dcd" },
                    { "b0b6aaf7-7cb8-46c0-8d9b-9bc33b74a18b", "d7f7e683-6bfc-4aa5-9430-0e20c9c37d5f" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_PostId",
                table: "Comment",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AuthorId",
                table: "Posts",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3973fd72-3bc2-42ee-821a-7bd486f04baf", "168bcb6a-32c3-4db3-b15f-2dc8a94215ee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8363f261-44e0-446d-85d0-12fe94b70305", "6580cc12-7cd9-4682-84df-1947aa823a11" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6e076e4b-71ee-425c-af7f-42b0f2d20d18", "abd8eb1f-a799-45e6-9188-22e3f3e74dcd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b0b6aaf7-7cb8-46c0-8d9b-9bc33b74a18b", "d7f7e683-6bfc-4aa5-9430-0e20c9c37d5f" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "61bc3a32-d1eb-499e-910a-fa7699edad6d");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "819aa564-88f1-4834-97b6-3aab82e01933");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "90787e3b-d784-4c33-ae07-c16815daf510");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "c64affb2-1891-47d4-85b6-7f3023a9308a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3973fd72-3bc2-42ee-821a-7bd486f04baf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6e076e4b-71ee-425c-af7f-42b0f2d20d18");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8363f261-44e0-446d-85d0-12fe94b70305");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b0b6aaf7-7cb8-46c0-8d9b-9bc33b74a18b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "168bcb6a-32c3-4db3-b15f-2dc8a94215ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6580cc12-7cd9-4682-84df-1947aa823a11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abd8eb1f-a799-45e6-9188-22e3f3e74dcd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d7f7e683-6bfc-4aa5-9430-0e20c9c37d5f");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}

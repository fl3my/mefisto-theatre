using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MefistoTheatre.Data.Migrations
{
    public partial class AddCommentRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_Posts_PostId",
                table: "Comment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8f2a16ed-502f-49b0-9abb-6e0dabed8a8a", "05c78efe-f37b-4ddf-a607-cef83a34256c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2e03c7ee-938b-46d2-9b51-cc33e8d9dd8b", "4b3ff9fc-507c-4ac7-b891-508137ff7218" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cfc90435-d2d0-434a-a608-b183eb4a144a", "82a8b95f-c1f5-4114-ab4b-d2350304766a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "368f4427-94d5-4bbe-a831-c3d4a5a95b30", "fffdc1ac-7777-4c39-8ece-4af1c06bcccd" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "732c7428-1575-4310-8f17-d40dec02d14a");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "a1cfe245-1485-4ba9-bc0b-5aeed6b05e37");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "a553c7d0-005d-470a-a44d-af7aa97a8d36");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "e6d1516f-5068-413a-b306-23d7eedbfd26");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e03c7ee-938b-46d2-9b51-cc33e8d9dd8b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "368f4427-94d5-4bbe-a831-c3d4a5a95b30");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f2a16ed-502f-49b0-9abb-6e0dabed8a8a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cfc90435-d2d0-434a-a608-b183eb4a144a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05c78efe-f37b-4ddf-a607-cef83a34256c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4b3ff9fc-507c-4ac7-b891-508137ff7218");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82a8b95f-c1f5-4114-ab4b-d2350304766a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fffdc1ac-7777-4c39-8ece-4af1c06bcccd");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_PostId",
                table: "Comments",
                newName: "IX_Comments_PostId");

            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "CommentId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "395a9500-a37f-40b7-9f1d-19214351739c", "1369eaa7-aa2f-47f5-9606-7aab3ffbbb70", "Admin", "ADMIN" },
                    { "4159f723-2beb-402f-a30f-e47c250b8044", "46cc7b30-afb3-4ea1-8eac-a8260d1878f2", "Basic", "BASIC" },
                    { "677cd56d-c8a8-47a5-8551-076bb777b37e", "43901731-b56b-49f0-a8b4-9f005fd28cdd", "Staff", "STAFF" },
                    { "b582bbd3-b4d9-40c2-b2ba-39cb1580486f", "17284858-6019-4f40-b2fb-4483d2933ec2", "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "IsSuspended", "Joined", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2e5598f7-43cc-4fe6-b914-748af4c459d4", 0, null, null, "9f2f9608-cf67-4a1e-980a-ab1d2b4e941b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic@basic.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "BASIC@BASIC.COM", "BASIC@BASIC.COM", "AQAAAAEAACcQAAAAEAvyXnsvLh90EcHQ6Su2lN08uJXMS/BVtGV1EeDAXAtzy9c/vrGmCIb4vJOrrRMKxA==", null, false, null, "de688639-4a83-4302-8bc1-4ed40299e403", false, "basic@basic.com" },
                    { "bc9c137b-c0b6-416e-9aa2-57cecef86d27", 0, null, null, "40893944-f977-4206-80d4-6dd7c2e1bc34", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "STAFF@MEFISTO.COM", "STAFF@MEFISTO.COM", "AQAAAAEAACcQAAAAEL5qnbqe9QqCMbj8n8Y+Shc3qtHNl0IutBFWwbOLdHM5WBMJi1AnJQOwn3ceZuSuAA==", null, false, null, "455faf56-eb40-48a2-a147-f2c75d36c2d0", false, "staff@mefisto.com" },
                    { "d1f9fc6c-76c2-4898-abef-4cd5e8e535a1", 0, null, null, "30bab1ca-f5b7-4cdf-a94c-891535288148", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "ADMIN@MEFISTO.COM", "ADMIN@MEFISTO.COM", "AQAAAAEAACcQAAAAEAJf3vNAqO+yHIAMxCyEkVd/oqxWH/hO89oyf9VlZV/gRZIgkhqf+VOsFPCuBToJ5Q==", null, false, null, "b9bf38f1-0b66-4524-acd1-afedc9433223", false, "admin@mefisto.com" },
                    { "e5dcbd68-8a00-4942-9acf-c178976b5570", 0, null, null, "9b08121e-9a5e-4f83-804f-4d50af3b6434", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "editor@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "EDITOR@MEFISTO.COM", "EDITOR@MEFISTO.COM", "AQAAAAEAACcQAAAAENvlbTHlHPvOgxf3pnwzo5KCUlebZhTbyko1vBBu/40TK7QeJZIoAph7cKXPHJpwSw==", null, false, null, "aff1b48b-c0b0-4b0c-93a6-4def185de73a", false, "editor@mefisto.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "28dd7664-21ec-4344-985f-d6dc0f175b0b", "Interview" },
                    { "7e3da3f5-0e71-4e70-b082-6d48a459b01e", "Announcements" },
                    { "9cad2b2b-54d8-4b64-a8db-3b51fe1bbc1b", "Features" },
                    { "e965b611-94d2-41fe-98e3-862c28f088bf", "Review" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "4159f723-2beb-402f-a30f-e47c250b8044", "2e5598f7-43cc-4fe6-b914-748af4c459d4" },
                    { "677cd56d-c8a8-47a5-8551-076bb777b37e", "bc9c137b-c0b6-416e-9aa2-57cecef86d27" },
                    { "395a9500-a37f-40b7-9f1d-19214351739c", "d1f9fc6c-76c2-4898-abef-4cd5e8e535a1" },
                    { "b582bbd3-b4d9-40c2-b2ba-39cb1580486f", "e5dcbd68-8a00-4942-9acf-c178976b5570" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_AuthorId",
                table: "Comments",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_AuthorId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4159f723-2beb-402f-a30f-e47c250b8044", "2e5598f7-43cc-4fe6-b914-748af4c459d4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "677cd56d-c8a8-47a5-8551-076bb777b37e", "bc9c137b-c0b6-416e-9aa2-57cecef86d27" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "395a9500-a37f-40b7-9f1d-19214351739c", "d1f9fc6c-76c2-4898-abef-4cd5e8e535a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b582bbd3-b4d9-40c2-b2ba-39cb1580486f", "e5dcbd68-8a00-4942-9acf-c178976b5570" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "28dd7664-21ec-4344-985f-d6dc0f175b0b");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "7e3da3f5-0e71-4e70-b082-6d48a459b01e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "9cad2b2b-54d8-4b64-a8db-3b51fe1bbc1b");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "e965b611-94d2-41fe-98e3-862c28f088bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "395a9500-a37f-40b7-9f1d-19214351739c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4159f723-2beb-402f-a30f-e47c250b8044");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "677cd56d-c8a8-47a5-8551-076bb777b37e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b582bbd3-b4d9-40c2-b2ba-39cb1580486f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e5598f7-43cc-4fe6-b914-748af4c459d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc9c137b-c0b6-416e-9aa2-57cecef86d27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d1f9fc6c-76c2-4898-abef-4cd5e8e535a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5dcbd68-8a00-4942-9acf-c178976b5570");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_PostId",
                table: "Comment",
                newName: "IX_Comment_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "CommentId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e03c7ee-938b-46d2-9b51-cc33e8d9dd8b", "63436661-33a1-4118-a7e3-ca75520afca7", "Staff", "STAFF" },
                    { "368f4427-94d5-4bbe-a831-c3d4a5a95b30", "898ee63b-9862-4f9b-b681-a8b45fd8af76", "Basic", "BASIC" },
                    { "8f2a16ed-502f-49b0-9abb-6e0dabed8a8a", "853d3cbc-1603-473c-8ad3-8d24786a8420", "Admin", "ADMIN" },
                    { "cfc90435-d2d0-434a-a608-b183eb4a144a", "71994aa9-42f7-4144-b689-220652636d12", "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "IsSuspended", "Joined", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "05c78efe-f37b-4ddf-a607-cef83a34256c", 0, null, null, "bf4092ca-f6be-4422-9198-ad2df3ce4559", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "ADMIN@MEFISTO.COM", "ADMIN@MEFISTO.COM", "AQAAAAEAACcQAAAAELf9Q8rd5NQVpJlePFv8Tr7EXw1FM1dWA8SSUej9pEnvDU5NZYkilwgkiPML53iAJA==", null, false, null, "c45cc7dd-db41-4562-893d-2faf25757a47", false, "admin@mefisto.com" },
                    { "4b3ff9fc-507c-4ac7-b891-508137ff7218", 0, null, null, "81dff5fc-ab91-452f-b273-b7d011b19b51", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "STAFF@MEFISTO.COM", "STAFF@MEFISTO.COM", "AQAAAAEAACcQAAAAEBbIqGIqOzEzzey56IpShwLtCZqsFfsIwArb0LhlcToScEtSsVc6o4uW8iGAtIYhRg==", null, false, null, "f2517991-4f19-4396-b0bb-1167e1b39acc", false, "staff@mefisto.com" },
                    { "82a8b95f-c1f5-4114-ab4b-d2350304766a", 0, null, null, "42bab17f-e948-4992-ae1a-f7e2cb4326cc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "editor@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "EDITOR@MEFISTO.COM", "EDITOR@MEFISTO.COM", "AQAAAAEAACcQAAAAEJnmK+QdAw2p2Act02Gqs4b2xiSdxz+jGObg3lCBmz4Gayzy59RuTe7D6biWK18UjQ==", null, false, null, "74157b26-eb31-4311-a4ea-4051b1d8ebde", false, "editor@mefisto.com" },
                    { "fffdc1ac-7777-4c39-8ece-4af1c06bcccd", 0, null, null, "9cf391a1-7e5a-402d-9734-c855731a2ee6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic@basic.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "BASIC@BASIC.COM", "BASIC@BASIC.COM", "AQAAAAEAACcQAAAAEIFPrBUqvWWyDg2qMKFgeL1JyfoL031sf9d7FFTJoohGticzq2/fQYaID3mzE98OXA==", null, false, null, "f91fe2db-2ddf-421f-8360-b65e752766de", false, "basic@basic.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "732c7428-1575-4310-8f17-d40dec02d14a", "Interview" },
                    { "a1cfe245-1485-4ba9-bc0b-5aeed6b05e37", "Announcements" },
                    { "a553c7d0-005d-470a-a44d-af7aa97a8d36", "Features" },
                    { "e6d1516f-5068-413a-b306-23d7eedbfd26", "Review" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "8f2a16ed-502f-49b0-9abb-6e0dabed8a8a", "05c78efe-f37b-4ddf-a607-cef83a34256c" },
                    { "2e03c7ee-938b-46d2-9b51-cc33e8d9dd8b", "4b3ff9fc-507c-4ac7-b891-508137ff7218" },
                    { "cfc90435-d2d0-434a-a608-b183eb4a144a", "82a8b95f-c1f5-4114-ab4b-d2350304766a" },
                    { "368f4427-94d5-4bbe-a831-c3d4a5a95b30", "fffdc1ac-7777-4c39-8ece-4af1c06bcccd" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_Posts_PostId",
                table: "Comment",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId");
        }
    }
}

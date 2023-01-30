using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MefistoTheatre.Data.Migrations
{
    public partial class AddEnumStatusToPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "468ecb2f-7343-46c8-bc48-f8e917bdf8b2", "78bf25c8-7ecb-4475-8c54-af632f2e099e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7b86d41c-76b8-41b8-a4b2-be13ba587f89", "acee1c01-d766-472b-8a96-86ee80795ab8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fe93639c-6a14-4618-b81f-f34624121440", "bba17518-9195-44f0-9b65-d5e415ff7a24" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cc9c5233-9ded-431c-ad0e-4b951ecc7336", "cb15230c-5329-4cdf-854c-6d5724582d5c" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "386de458-6344-4b80-9775-6b060571d570");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "5063ecd9-9fb9-488a-a93b-4227d8efbe36");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "68160c01-829a-4270-9e0f-6aeaea7b3f8c");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "b81f392d-acf4-40ea-9aea-226e0fed3f27");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "468ecb2f-7343-46c8-bc48-f8e917bdf8b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b86d41c-76b8-41b8-a4b2-be13ba587f89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc9c5233-9ded-431c-ad0e-4b951ecc7336");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe93639c-6a14-4618-b81f-f34624121440");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78bf25c8-7ecb-4475-8c54-af632f2e099e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acee1c01-d766-472b-8a96-86ee80795ab8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bba17518-9195-44f0-9b65-d5e415ff7a24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb15230c-5329-4cdf-854c-6d5724582d5c");

            migrationBuilder.DropColumn(
                name: "Published",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ToBeReviewed",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Posts");

            migrationBuilder.AddColumn<bool>(
                name: "Published",
                table: "Posts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ToBeReviewed",
                table: "Posts",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "468ecb2f-7343-46c8-bc48-f8e917bdf8b2", "a8ab8402-5954-4ae1-b815-e7f851761bd6", "Admin", "ADMIN" },
                    { "7b86d41c-76b8-41b8-a4b2-be13ba587f89", "58cca5f0-ab81-41c8-8150-56b32df9c69a", "Editor", "EDITOR" },
                    { "cc9c5233-9ded-431c-ad0e-4b951ecc7336", "be17edec-c781-4a77-a395-7aaf0b70ab55", "Basic", "BASIC" },
                    { "fe93639c-6a14-4618-b81f-f34624121440", "eb938d2b-a481-49d0-bfe4-a4d4aae5235b", "Staff", "STAFF" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "IsSuspended", "Joined", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "78bf25c8-7ecb-4475-8c54-af632f2e099e", 0, null, null, "7cc4a9dd-3631-422b-bd33-d814b42e209a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "ADMIN@MEFISTO.COM", "ADMIN@MEFISTO.COM", "AQAAAAEAACcQAAAAEI3YCDDkYoQ8gvxExi9SiKGJGOfhaSwFOkCJsmZZeNugM+3E3soQ9zb415i1qgbaag==", null, false, null, "0affc1af-5f30-4422-844d-bcbd9470a02c", false, "admin@mefisto.com" },
                    { "acee1c01-d766-472b-8a96-86ee80795ab8", 0, null, null, "a5880d70-2b64-49ae-8d38-73c8e5d24138", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "editor@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "EDITOR@MEFISTO.COM", "EDITOR@MEFISTO.COM", "AQAAAAEAACcQAAAAEMtkpTOjSWEl2UUCG36DRdCatV5I5BkkINyS6y63LUPZtHDmL90UKq/TmoIPr4WafQ==", null, false, null, "72174ef1-c028-42b8-be19-9ef5529ccf57", false, "editor@mefisto.com" },
                    { "bba17518-9195-44f0-9b65-d5e415ff7a24", 0, null, null, "298ce558-54ef-4109-8d0d-9de7960031c3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "STAFF@MEFISTO.COM", "STAFF@MEFISTO.COM", "AQAAAAEAACcQAAAAENgLOJqJxqcSeze14fgmh1F4uQ2JXcNk32xosCX4QPZ9N8UbrqyE3jERDKH2d9B3eg==", null, false, null, "78aea3ee-c881-4160-b92f-b6d2e0065b71", false, "staff@mefisto.com" },
                    { "cb15230c-5329-4cdf-854c-6d5724582d5c", 0, null, null, "72941822-f9b8-483e-b5d2-66f7d1d99578", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic@basic.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "BASIC@BASIC.COM", "BASIC@BASIC.COM", "AQAAAAEAACcQAAAAENwEoYDWXd0xpTcu7UVLvf1O3qegyhC/GKoB8FlUP71yA7aseb/VHWl21yjtfBqsug==", null, false, null, "b9329505-c784-4485-be2e-a5b543a9e559", false, "basic@basic.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "386de458-6344-4b80-9775-6b060571d570", "Review" },
                    { "5063ecd9-9fb9-488a-a93b-4227d8efbe36", "Interview" },
                    { "68160c01-829a-4270-9e0f-6aeaea7b3f8c", "Features" },
                    { "b81f392d-acf4-40ea-9aea-226e0fed3f27", "Announcements" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "468ecb2f-7343-46c8-bc48-f8e917bdf8b2", "78bf25c8-7ecb-4475-8c54-af632f2e099e" },
                    { "7b86d41c-76b8-41b8-a4b2-be13ba587f89", "acee1c01-d766-472b-8a96-86ee80795ab8" },
                    { "fe93639c-6a14-4618-b81f-f34624121440", "bba17518-9195-44f0-9b65-d5e415ff7a24" },
                    { "cc9c5233-9ded-431c-ad0e-4b951ecc7336", "cb15230c-5329-4cdf-854c-6d5724582d5c" }
                });
        }
    }
}

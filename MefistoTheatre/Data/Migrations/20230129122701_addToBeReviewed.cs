using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MefistoTheatre.Data.Migrations
{
    public partial class addToBeReviewed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "862e577c-ecab-469c-b591-84b1115f39d7", "3c7022c8-2b9c-4bd0-852c-4cb6461d8551" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2942fada-2e26-4964-8349-c3d39d94598e", "62c5432a-2bc4-439c-8b96-214c6cd6976d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ed27a376-9eb7-4752-84d3-34d4e45b02cb", "9a8b960c-4134-4670-83e1-9d64982dbdca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "39c2e414-5eca-4c8e-be75-91f244fc794f", "fc512a3c-df95-4bfc-91b6-6f404e3d8857" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "1bada464-9021-4774-9bc7-9fa128bf492d");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "df39f279-5ec9-4de1-ae08-53d85b4d3b74");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "f40608b5-67a4-4375-84fa-0132375be886");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "f6b79708-fbc7-4ab2-8cab-7ac19703a865");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2942fada-2e26-4964-8349-c3d39d94598e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39c2e414-5eca-4c8e-be75-91f244fc794f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "862e577c-ecab-469c-b591-84b1115f39d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed27a376-9eb7-4752-84d3-34d4e45b02cb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c7022c8-2b9c-4bd0-852c-4cb6461d8551");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62c5432a-2bc4-439c-8b96-214c6cd6976d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a8b960c-4134-4670-83e1-9d64982dbdca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc512a3c-df95-4bfc-91b6-6f404e3d8857");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "ToBeReviewed",
                table: "Posts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2942fada-2e26-4964-8349-c3d39d94598e", "1967be20-4c68-4a6b-864b-4edbd36f0d2a", "Staff", "STAFF" },
                    { "39c2e414-5eca-4c8e-be75-91f244fc794f", "bfffc3c6-d1ff-4fb7-ba96-41003ce0f948", "Basic", "BASIC" },
                    { "862e577c-ecab-469c-b591-84b1115f39d7", "f25419b9-76b3-4b14-a24a-d5319e3431b1", "Admin", "ADMIN" },
                    { "ed27a376-9eb7-4752-84d3-34d4e45b02cb", "d2e90dea-16a7-4179-ad50-50a5bf5d35d2", "Editor", "EDITOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "IsSuspended", "Joined", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3c7022c8-2b9c-4bd0-852c-4cb6461d8551", 0, null, null, "579e43a9-7fb9-4029-b48f-5310558de245", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "ADMIN@MEFISTO.COM", "ADMIN@MEFISTO.COM", "AQAAAAEAACcQAAAAEEQWymPr2Ap8+qZgovUVYyh107e3VocTlzZgaSfBH3JOGk7GRiaKJ1IHl7ff53FVww==", null, false, null, "04fc0306-6113-421f-bc5c-e1829f8d9611", false, "admin@mefisto.com" },
                    { "62c5432a-2bc4-439c-8b96-214c6cd6976d", 0, null, null, "1feef692-5eb8-4cee-9ccc-a872d0eb33b8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "STAFF@MEFISTO.COM", "STAFF@MEFISTO.COM", "AQAAAAEAACcQAAAAEB5YthaTtdPk0BfB1WcckZJr2WMEwSX5B/WQB6ubJ+6jfTUFmWfEUbLNJG7OlXpJbg==", null, false, null, "36b89a93-1f90-4136-825b-ee68ed77be41", false, "staff@mefisto.com" },
                    { "9a8b960c-4134-4670-83e1-9d64982dbdca", 0, null, null, "94312264-643e-4ce7-be34-429867f48582", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "editor@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "EDITOR@MEFISTO.COM", "EDITOR@MEFISTO.COM", "AQAAAAEAACcQAAAAEBUi8sn+i8Icq3ez2q57cof5W2yx739hz4T6z1PTAxyxDTaAqle2MaQ0Kx7mzVmznQ==", null, false, null, "96ebe5f6-5224-4ad7-811d-7ed63ae1fe8a", false, "editor@mefisto.com" },
                    { "fc512a3c-df95-4bfc-91b6-6f404e3d8857", 0, null, null, "be61799a-24a1-4009-8326-9f299b3bf6c8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic@basic.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "BASIC@BASIC.COM", "BASIC@BASIC.COM", "AQAAAAEAACcQAAAAEEihfIylKVR36Vr1yw/FNEzzfT8RdWvEGYmQPq3t02sOhPwqv+PjqIlNlztSGJ7ISQ==", null, false, null, "d487f2b6-997f-4435-9d1d-eae8a3e8cf5b", false, "basic@basic.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "1bada464-9021-4774-9bc7-9fa128bf492d", "Features" },
                    { "df39f279-5ec9-4de1-ae08-53d85b4d3b74", "Interview" },
                    { "f40608b5-67a4-4375-84fa-0132375be886", "Review" },
                    { "f6b79708-fbc7-4ab2-8cab-7ac19703a865", "Announcements" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "862e577c-ecab-469c-b591-84b1115f39d7", "3c7022c8-2b9c-4bd0-852c-4cb6461d8551" },
                    { "2942fada-2e26-4964-8349-c3d39d94598e", "62c5432a-2bc4-439c-8b96-214c6cd6976d" },
                    { "ed27a376-9eb7-4752-84d3-34d4e45b02cb", "9a8b960c-4134-4670-83e1-9d64982dbdca" },
                    { "39c2e414-5eca-4c8e-be75-91f244fc794f", "fc512a3c-df95-4bfc-91b6-6f404e3d8857" }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MefistoTheatre.Data.Migrations
{
    public partial class AddNullColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedAt",
                table: "Posts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishedAt",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
        }
    }
}

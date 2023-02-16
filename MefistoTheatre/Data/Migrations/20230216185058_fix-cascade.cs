using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MefistoTheatre.Data.Migrations
{
    public partial class fixcascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
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

            migrationBuilder.AlterColumn<string>(
                name: "PostId",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11954cc1-242b-46be-a16c-0c8a1db982ea", "cc424228-edb2-43f5-b1c6-62cd39f7cfdd", "Admin", "ADMIN" },
                    { "33d6329f-cd13-4929-90d2-0a3c8015e78e", "97488b4e-387b-40e6-9976-c3d6dff9909b", "Staff", "STAFF" },
                    { "6df28832-7c96-4e04-96a0-0cda4e2bba0b", "9314d068-4a43-4244-8381-6b6b45e20576", "Editor", "EDITOR" },
                    { "9216d8dc-d1cb-4768-946b-a6aae076b053", "74478cd8-8451-434e-8cfe-54b630b465c3", "Basic", "BASIC" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "IsSuspended", "Joined", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PostCode", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "39738235-8493-453a-abea-2573efe727c4", 0, null, null, "6dc48fd0-cb43-4247-935d-448ececf6ffc", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "staff@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "STAFF@MEFISTO.COM", "STAFF@MEFISTO.COM", "AQAAAAEAACcQAAAAEPmoCw/KrkQHB5MW2623ybwN1iuOeQrku2JlqfrLAsx2vwQovXbb8eHSMgeqAyvJpA==", null, false, null, "281b6051-f9f1-49f3-9e43-4d6d5f8e00a9", false, "staff@mefisto.com" },
                    { "634824c3-1db4-4c59-af21-80267fa7ae00", 0, null, null, "d546ed70-5df3-45ae-a008-1445848975f2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "basic@basic.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "BASIC@BASIC.COM", "BASIC@BASIC.COM", "AQAAAAEAACcQAAAAEOTdtgxZdhxLB9tSnZF3B8Yo+nPEiPfDIxgpN1lQQbcEzbEczy0jnnAVSo+3DqSG2w==", null, false, null, "3f700215-bf2b-4422-90d9-71305dbdc84d", false, "basic@basic.com" },
                    { "77e8fe47-ad47-44b9-8fe7-d7398f98c80e", 0, null, null, "9a5b9e3e-c3a6-4795-853f-145a20aaeab6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "editor@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "EDITOR@MEFISTO.COM", "EDITOR@MEFISTO.COM", "AQAAAAEAACcQAAAAEMc2GKulKYn6wR6h0/LGvuXQvj9mJIpunZTA0Oe6TxjUM3v+qtDzqUlZjNCJfOrXyA==", null, false, null, "e55257ba-ba42-445c-8d99-bed3a4c59fa2", false, "editor@mefisto.com" },
                    { "bfd81596-d4c7-4236-9112-1dab11048210", 0, null, null, "b40e8b99-7c8c-47e8-9e3e-8834e8ddcf88", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@mefisto.com", true, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, null, "ADMIN@MEFISTO.COM", "ADMIN@MEFISTO.COM", "AQAAAAEAACcQAAAAEKhVUn8xw2Dy+MfACGjSviN3r7mQOn9YXSL6JW1wx9G1+g3bHpeGYiJG1NPQxU8K4g==", null, false, null, "1c0ff3a1-80d4-4282-baab-f6613644997e", false, "admin@mefisto.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "264cc9f6-718e-422b-9233-c011ca3f12b0", "Announcements" },
                    { "42b7c00a-47e7-406e-9842-5b85abc26f75", "Review" },
                    { "a7df97b7-2a7a-4a42-99ea-ff8221ee2eb3", "Features" },
                    { "de0256b1-9592-49f9-a33e-87b10fd5da20", "Interview" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "33d6329f-cd13-4929-90d2-0a3c8015e78e", "39738235-8493-453a-abea-2573efe727c4" },
                    { "9216d8dc-d1cb-4768-946b-a6aae076b053", "634824c3-1db4-4c59-af21-80267fa7ae00" },
                    { "6df28832-7c96-4e04-96a0-0cda4e2bba0b", "77e8fe47-ad47-44b9-8fe7-d7398f98c80e" },
                    { "11954cc1-242b-46be-a16c-0c8a1db982ea", "bfd81596-d4c7-4236-9112-1dab11048210" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "33d6329f-cd13-4929-90d2-0a3c8015e78e", "39738235-8493-453a-abea-2573efe727c4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9216d8dc-d1cb-4768-946b-a6aae076b053", "634824c3-1db4-4c59-af21-80267fa7ae00" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6df28832-7c96-4e04-96a0-0cda4e2bba0b", "77e8fe47-ad47-44b9-8fe7-d7398f98c80e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "11954cc1-242b-46be-a16c-0c8a1db982ea", "bfd81596-d4c7-4236-9112-1dab11048210" });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "264cc9f6-718e-422b-9233-c011ca3f12b0");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "42b7c00a-47e7-406e-9842-5b85abc26f75");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "a7df97b7-2a7a-4a42-99ea-ff8221ee2eb3");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "de0256b1-9592-49f9-a33e-87b10fd5da20");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11954cc1-242b-46be-a16c-0c8a1db982ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33d6329f-cd13-4929-90d2-0a3c8015e78e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6df28832-7c96-4e04-96a0-0cda4e2bba0b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9216d8dc-d1cb-4768-946b-a6aae076b053");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39738235-8493-453a-abea-2573efe727c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "634824c3-1db4-4c59-af21-80267fa7ae00");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77e8fe47-ad47-44b9-8fe7-d7398f98c80e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bfd81596-d4c7-4236-9112-1dab11048210");

            migrationBuilder.AlterColumn<string>(
                name: "PostId",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Posts_PostId",
                table: "Comments",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "PostId");
        }
    }
}

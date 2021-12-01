using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "8d8726be-4dfd-4462-a0a5-e1f8c88da8e2", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "9e285044-a2b9-413e-8b27-308c6ed8f81a", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "90b9039d-859e-40b5-b073-478d631919ff", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEHGRWmVyjMTmleQYwAekNwjMfkoIUrqMNXRkJw8MRzdb8Zzr1OxKoqSd1umJ1EjHvg==", null, false, "3d87f396-bca5-49c2-9cf9-f19c03d23fcb", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "Createdby", "DateCreated", "DateUpdated", "Name", "Updatedby" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 23, 16, 15, 15, 559, DateTimeKind.Local).AddTicks(620), new DateTime(2021, 11, 23, 16, 15, 15, 560, DateTimeKind.Local).AddTicks(9882), "Black", "System" },
                    { 2, "System", new DateTime(2021, 11, 23, 16, 15, 15, 561, DateTimeKind.Local).AddTicks(1597), new DateTime(2021, 11, 23, 16, 15, 15, 561, DateTimeKind.Local).AddTicks(1605), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "Createdby", "DateCreated", "DateUpdated", "Name", "Updatedby" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 23, 16, 15, 15, 563, DateTimeKind.Local).AddTicks(5144), new DateTime(2021, 11, 23, 16, 15, 15, 563, DateTimeKind.Local).AddTicks(5180), "BMW", "System" },
                    { 2, "System", new DateTime(2021, 11, 23, 16, 15, 15, 563, DateTimeKind.Local).AddTicks(5185), new DateTime(2021, 11, 23, 16, 15, 15, 563, DateTimeKind.Local).AddTicks(5186), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Createdby", "DateCreated", "DateUpdated", "Name", "Updatedby" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 11, 23, 16, 15, 15, 564, DateTimeKind.Local).AddTicks(2558), new DateTime(2021, 11, 23, 16, 15, 15, 564, DateTimeKind.Local).AddTicks(2578), "3 Series", "System" },
                    { 2, "System", new DateTime(2021, 11, 23, 16, 15, 15, 564, DateTimeKind.Local).AddTicks(2584), new DateTime(2021, 11, 23, 16, 15, 15, 564, DateTimeKind.Local).AddTicks(2586), "X5", "System" },
                    { 3, "System", new DateTime(2021, 11, 23, 16, 15, 15, 564, DateTimeKind.Local).AddTicks(2588), new DateTime(2021, 11, 23, 16, 15, 15, 564, DateTimeKind.Local).AddTicks(2590), "Prius", "System" },
                    { 4, "System", new DateTime(2021, 11, 23, 16, 15, 15, 564, DateTimeKind.Local).AddTicks(2592), new DateTime(2021, 11, 23, 16, 15, 15, 564, DateTimeKind.Local).AddTicks(2593), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class newdb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "cc04d4ac-cb08-4c43-a060-5ff25b22d553");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "a9a61d8a-8a65-44f7-a388-fa7a78b15b62");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a6d3957-6fc3-4e11-81f3-00245e4a69ed", "AQAAAAEAACcQAAAAEKo9oyu70+dgq3vGaHCb1I4FEkDhUptax323w3wewE7xRYPd3ptPm3w7s+m9t7JFgA==", "0495c784-8845-4ffe-b011-5474759ce0d9" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 13, 24, 28, 361, DateTimeKind.Local).AddTicks(2057), new DateTime(2022, 1, 11, 13, 24, 28, 362, DateTimeKind.Local).AddTicks(8133) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 13, 24, 28, 362, DateTimeKind.Local).AddTicks(9743), new DateTime(2022, 1, 11, 13, 24, 28, 362, DateTimeKind.Local).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 13, 24, 28, 365, DateTimeKind.Local).AddTicks(881), new DateTime(2022, 1, 11, 13, 24, 28, 365, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 13, 24, 28, 365, DateTimeKind.Local).AddTicks(905), new DateTime(2022, 1, 11, 13, 24, 28, 365, DateTimeKind.Local).AddTicks(907) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 13, 24, 28, 365, DateTimeKind.Local).AddTicks(7138), new DateTime(2022, 1, 11, 13, 24, 28, 365, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 13, 24, 28, 365, DateTimeKind.Local).AddTicks(7152), new DateTime(2022, 1, 11, 13, 24, 28, 365, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 13, 24, 28, 365, DateTimeKind.Local).AddTicks(7156), new DateTime(2022, 1, 11, 13, 24, 28, 365, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 11, 13, 24, 28, 365, DateTimeKind.Local).AddTicks(7160), new DateTime(2022, 1, 11, 13, 24, 28, 365, DateTimeKind.Local).AddTicks(7162) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "3c2ea8cd-579c-4922-b28f-15792ca29376");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "d0d5929e-9723-4de9-8525-24a24651a9e6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bb5d940-e8eb-4a6a-9917-9339a9102336", "AQAAAAEAACcQAAAAEIaArYh5LbUej0RQTkawRSn4HxAiaqYGlKvmr0KnIC3T0CBtIKOa4f4J+4GOVe2a7w==", "c4817620-e7d7-4b9a-b5e7-7fd066720dbd" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 52, 2, 310, DateTimeKind.Local).AddTicks(9892), new DateTime(2022, 1, 4, 15, 52, 2, 312, DateTimeKind.Local).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 52, 2, 312, DateTimeKind.Local).AddTicks(976), new DateTime(2022, 1, 4, 15, 52, 2, 312, DateTimeKind.Local).AddTicks(982) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 52, 2, 313, DateTimeKind.Local).AddTicks(5724), new DateTime(2022, 1, 4, 15, 52, 2, 313, DateTimeKind.Local).AddTicks(5742) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 52, 2, 313, DateTimeKind.Local).AddTicks(5745), new DateTime(2022, 1, 4, 15, 52, 2, 313, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 52, 2, 313, DateTimeKind.Local).AddTicks(9580), new DateTime(2022, 1, 4, 15, 52, 2, 313, DateTimeKind.Local).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 52, 2, 313, DateTimeKind.Local).AddTicks(9590), new DateTime(2022, 1, 4, 15, 52, 2, 313, DateTimeKind.Local).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 52, 2, 313, DateTimeKind.Local).AddTicks(9592), new DateTime(2022, 1, 4, 15, 52, 2, 313, DateTimeKind.Local).AddTicks(9593) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 15, 52, 2, 313, DateTimeKind.Local).AddTicks(9595), new DateTime(2022, 1, 4, 15, 52, 2, 313, DateTimeKind.Local).AddTicks(9596) });
        }
    }
}

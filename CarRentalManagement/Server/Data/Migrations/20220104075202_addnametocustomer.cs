using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class addnametocustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "eb8a90a2-a9c6-42c9-9b97-f75df9e3e2ee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "5dae7e87-88bb-41b5-92c9-e67d9f546134");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "366b4685-d57c-4cd4-8e9b-f80f544b993a", "AQAAAAEAACcQAAAAEGXxsj8TOT1D/kJw/zqFTpOxAwUwtZj9u1WsWWLOcuQzktEjjbBFgvMQk/cGAlV3VA==", "79da140f-07e7-4bc4-aea6-c712f43498c1" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 14, 56, 43, 8, DateTimeKind.Local).AddTicks(9496), new DateTime(2022, 1, 4, 14, 56, 43, 10, DateTimeKind.Local).AddTicks(2908) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 14, 56, 43, 10, DateTimeKind.Local).AddTicks(4043), new DateTime(2022, 1, 4, 14, 56, 43, 10, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 14, 56, 43, 12, DateTimeKind.Local).AddTicks(900), new DateTime(2022, 1, 4, 14, 56, 43, 12, DateTimeKind.Local).AddTicks(918) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 14, 56, 43, 12, DateTimeKind.Local).AddTicks(923), new DateTime(2022, 1, 4, 14, 56, 43, 12, DateTimeKind.Local).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 14, 56, 43, 12, DateTimeKind.Local).AddTicks(5735), new DateTime(2022, 1, 4, 14, 56, 43, 12, DateTimeKind.Local).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 14, 56, 43, 12, DateTimeKind.Local).AddTicks(5753), new DateTime(2022, 1, 4, 14, 56, 43, 12, DateTimeKind.Local).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 14, 56, 43, 12, DateTimeKind.Local).AddTicks(5757), new DateTime(2022, 1, 4, 14, 56, 43, 12, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 14, 56, 43, 12, DateTimeKind.Local).AddTicks(5760), new DateTime(2022, 1, 4, 14, 56, 43, 12, DateTimeKind.Local).AddTicks(5762) });
        }
    }
}

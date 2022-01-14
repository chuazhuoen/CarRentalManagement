using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class newdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Vehicles",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Createdby",
                table: "Vehicles",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Models",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Createdby",
                table: "Models",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Makes",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Createdby",
                table: "Makes",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Customers",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Createdby",
                table: "Customers",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Colours",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Createdby",
                table: "Colours",
                newName: "CreatedBy");

            migrationBuilder.RenameColumn(
                name: "Updatedby",
                table: "Bookings",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Createdby",
                table: "Bookings",
                newName: "CreatedBy");

            migrationBuilder.AddColumn<double>(
                name: "RentalRate",
                table: "Vehicles",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RentalRate",
                table: "Vehicles");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Vehicles",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Vehicles",
                newName: "Createdby");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Models",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Models",
                newName: "Createdby");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Makes",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Makes",
                newName: "Createdby");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Customers",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Customers",
                newName: "Createdby");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Colours",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Colours",
                newName: "Createdby");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Bookings",
                newName: "Updatedby");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Bookings",
                newName: "Createdby");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                column: "ConcurrencyStamp",
                value: "8d8726be-4dfd-4462-a0a5-e1f8c88da8e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                column: "ConcurrencyStamp",
                value: "9e285044-a2b9-413e-8b27-308c6ed8f81a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90b9039d-859e-40b5-b073-478d631919ff", "AQAAAAEAACcQAAAAEHGRWmVyjMTmleQYwAekNwjMfkoIUrqMNXRkJw8MRzdb8Zzr1OxKoqSd1umJ1EjHvg==", "3d87f396-bca5-49c2-9cf9-f19c03d23fcb" });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 16, 15, 15, 559, DateTimeKind.Local).AddTicks(620), new DateTime(2021, 11, 23, 16, 15, 15, 560, DateTimeKind.Local).AddTicks(9882) });

            migrationBuilder.UpdateData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 16, 15, 15, 561, DateTimeKind.Local).AddTicks(1597), new DateTime(2021, 11, 23, 16, 15, 15, 561, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 16, 15, 15, 563, DateTimeKind.Local).AddTicks(5144), new DateTime(2021, 11, 23, 16, 15, 15, 563, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 16, 15, 15, 563, DateTimeKind.Local).AddTicks(5185), new DateTime(2021, 11, 23, 16, 15, 15, 563, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 16, 15, 15, 564, DateTimeKind.Local).AddTicks(2558), new DateTime(2021, 11, 23, 16, 15, 15, 564, DateTimeKind.Local).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 16, 15, 15, 564, DateTimeKind.Local).AddTicks(2584), new DateTime(2021, 11, 23, 16, 15, 15, 564, DateTimeKind.Local).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 16, 15, 15, 564, DateTimeKind.Local).AddTicks(2588), new DateTime(2021, 11, 23, 16, 15, 15, 564, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 11, 23, 16, 15, 15, 564, DateTimeKind.Local).AddTicks(2592), new DateTime(2021, 11, 23, 16, 15, 15, 564, DateTimeKind.Local).AddTicks(2593) });
        }
    }
}

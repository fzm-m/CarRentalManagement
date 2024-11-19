using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 35, 9, 739, DateTimeKind.Local).AddTicks(1114), new DateTime(2024, 11, 18, 17, 35, 9, 739, DateTimeKind.Local).AddTicks(1124), "Black", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 35, 9, 739, DateTimeKind.Local).AddTicks(1126), new DateTime(2024, 11, 18, 17, 35, 9, 739, DateTimeKind.Local).AddTicks(1127), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 35, 9, 739, DateTimeKind.Local).AddTicks(1274), new DateTime(2024, 11, 18, 17, 35, 9, 739, DateTimeKind.Local).AddTicks(1275), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 35, 9, 739, DateTimeKind.Local).AddTicks(1276), new DateTime(2024, 11, 18, 17, 35, 9, 739, DateTimeKind.Local).AddTicks(1276), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 17, 35, 9, 739, DateTimeKind.Local).AddTicks(1332), new DateTime(2024, 11, 18, 17, 35, 9, 739, DateTimeKind.Local).AddTicks(1332), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 17, 35, 9, 739, DateTimeKind.Local).AddTicks(1354), new DateTime(2024, 11, 18, 17, 35, 9, 739, DateTimeKind.Local).AddTicks(1355), "x5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 17, 35, 9, 739, DateTimeKind.Local).AddTicks(1356), new DateTime(2024, 11, 18, 17, 35, 9, 739, DateTimeKind.Local).AddTicks(1356), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 17, 35, 9, 739, DateTimeKind.Local).AddTicks(1357), new DateTime(2024, 11, 18, 17, 35, 9, 739, DateTimeKind.Local).AddTicks(1357), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}

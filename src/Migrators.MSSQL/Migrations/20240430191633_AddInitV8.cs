using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Migrators.MSSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddInitV8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CategoryServiceDetail",
                columns: new[] { "CategoryId", "ServiceId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000006") }
                });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "CreatedOn",
                value: new DateTime(2024, 1, 16, 22, 30, 3, 678, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "CreatedOn",
                value: new DateTime(2024, 1, 16, 22, 30, 3, 678, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryServiceDetail",
                keyColumns: new[] { "CategoryId", "ServiceId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000006") });

            migrationBuilder.DeleteData(
                table: "CategoryServiceDetail",
                keyColumns: new[] { "CategoryId", "ServiceId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000006") });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 22, 30, 3, 678, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "CreatedOn",
                value: new DateTime(2024, 1, 5, 22, 30, 3, 678, DateTimeKind.Local));
        }
    }
}

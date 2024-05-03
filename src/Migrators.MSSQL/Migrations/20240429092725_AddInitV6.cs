using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddInitV6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Collection",
                columns: new[] { "Id", "CollectionName", "CreatedBy", "CreatedOn", "Privacy" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), "Ảnh bìa đẹp", new Guid("00000000-0000-0000-0000-00000000000f"), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreatedOn",
                value: new DateTime(2023, 12, 29, 22, 30, 3, 678, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Collection",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "CreatedOn",
                value: new DateTime(2024, 12, 29, 22, 30, 3, 678, DateTimeKind.Local));
        }
    }
}

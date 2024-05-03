using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldsInWallet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Fee",
                table: "WalletHistory",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "WalletBalance",
                table: "WalletHistory",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Fee",
                table: "TransactionHistory",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "WalletBalance",
                table: "TransactionHistory",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000c"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000d"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000f"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "Fee", "WalletBalance" },
                values: new object[] { 0.0, 0.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fee",
                table: "WalletHistory");

            migrationBuilder.DropColumn(
                name: "WalletBalance",
                table: "WalletHistory");

            migrationBuilder.DropColumn(
                name: "Fee",
                table: "TransactionHistory");

            migrationBuilder.DropColumn(
                name: "WalletBalance",
                table: "TransactionHistory");
        }
    }
}

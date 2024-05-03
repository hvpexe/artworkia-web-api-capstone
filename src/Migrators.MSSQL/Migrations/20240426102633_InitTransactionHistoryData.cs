using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Migrators.MSSQL.Migrations
{
    /// <inheritdoc />
    public partial class InitTransactionHistoryData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000105"));

            migrationBuilder.DeleteData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000f"));

            migrationBuilder.DeleteData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000c"));

            migrationBuilder.DeleteData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000d"));

            migrationBuilder.DeleteData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000f"));

            migrationBuilder.DeleteData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "CreatedBy",
                value: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedBy", "CreatedOn", "Price", "WalletBalance" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2024, 1, 2, 22, 30, 3, 678, DateTimeKind.Local), -12000.0, 88000.0 });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "AssetId", "CreatedBy", "CreatedOn", "Detail", "Fee", "Price", "ToAccountId", "WalletBalance" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2024, 1, 2, 22, 30, 3, 678, DateTimeKind.Local), "Mở khóa tài nguyên \"Ảnh cánh cụt\"", 600.0, 11400.0, new Guid("00000000-0000-0000-0000-000000000004"), 81400.0 });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "AssetId", "CreatedBy", "CreatedOn", "Detail", "Price", "ToAccountId", "WalletBalance" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2024, 1, 5, 22, 30, 3, 678, DateTimeKind.Local), "Mở khóa tài nguyên \"Dấu vết của quá khứ\"", -10000.0, new Guid("00000000-0000-0000-0000-000000000002"), 40000.0 });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "CreatedBy", "CreatedOn", "Detail", "Fee", "Price", "ToAccountId", "WalletBalance" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 2, 1, 9, 59, 59, 0, DateTimeKind.Local), "Hoàn tất thanh toán thỏa thuận \"Làm web thiệp cưới\" (75%)", 3000.0, 57000.0, new Guid("00000000-0000-0000-0000-000000000005"), 163500.0 });

            migrationBuilder.InsertData(
                table: "TransactionHistory",
                columns: new[] { "Id", "AssetId", "CreatedBy", "CreatedOn", "Detail", "Fee", "Price", "ProposalId", "ToAccountId", "TransactionStatus", "WalletBalance" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 1, 5, 22, 30, 3, 678, DateTimeKind.Local), "Mở khóa tài nguyên \"Dấu vết của quá khứ\"", 500.0, 9500.0, null, new Guid("00000000-0000-0000-0000-000000000004"), 1, 119500.0 },
                    { new Guid("00000000-0000-0000-0000-000000000005"), new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 1, 15, 9, 59, 59, 0, DateTimeKind.Local), "Mở khóa tài nguyên \"File PTS tuyển tập minh hoạ sách tâm lý\"", 0.0, -20000.0, null, new Guid("00000000-0000-0000-0000-000000000004"), 1, 99500.0 },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2024, 1, 15, 9, 59, 59, 0, DateTimeKind.Local), "Mở khóa tài nguyên \"File PTS tuyển tập minh hoạ sách tâm lý\"", 1000.0, 19000.0, null, new Guid("00000000-0000-0000-0000-000000000002"), 1, 59000.0 },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2024, 1, 16, 22, 30, 3, 678, DateTimeKind.Local), "Mở khóa tài nguyên \"Không gian vũ trụ\"", 0.0, -50000.0, null, new Guid("00000000-0000-0000-0000-00000000000b"), 1, 9000.0 },
                    { new Guid("00000000-0000-0000-0000-000000000008"), new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-00000000000b"), new DateTime(2024, 1, 16, 22, 30, 3, 678, DateTimeKind.Local), "Mở khóa tài nguyên \"Không gian vũ trụ\"", 2500.0, 47500.0, null, new Guid("00000000-0000-0000-0000-000000000004"), 1, 47500.0 },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 1, 14, 22, 30, 3, 678, DateTimeKind.Local), "Mở khóa tài nguyên \"Ảnh cánh cụt\"", 0.0, -12000.0, null, new Guid("00000000-0000-0000-0000-000000000005"), 1, 87500.0 },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2024, 1, 14, 22, 30, 3, 678, DateTimeKind.Local), "Mở khóa tài nguyên \"Ảnh cánh cụt\"", 600.0, 11400.0, null, new Guid("00000000-0000-0000-0000-000000000002"), 1, 92800.0 },
                    { new Guid("00000000-0000-0000-0000-000000000101"), null, new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2024, 1, 3, 9, 59, 59, 0, DateTimeKind.Local), "Đặt cọc thỏa thuận \"Làm web thiệp cưới\" (25%)", 0.0, -20000.0, new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002"), 1, 72800.0 },
                    { new Guid("00000000-0000-0000-0000-000000000102"), null, new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 1, 3, 9, 59, 59, 0, DateTimeKind.Local), "Đặt cọc thỏa thuận \"Làm web thiệp cưới\" (25%)", 1000.0, 19000.0, new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000005"), 1, 106500.0 },
                    { new Guid("00000000-0000-0000-0000-000000000103"), null, new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2024, 2, 1, 9, 59, 59, 0, DateTimeKind.Local), "Hoàn tất thanh toán thỏa thuận \"Làm web thiệp cưới\" (75%)", 0.0, -60000.0, new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002"), 1, 12800.0 }
                });

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Balance",
                value: 10000.0);

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Balance",
                value: 163500.0);

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "Balance", "WithdrawInformation" },
                values: new object[] { 10000.0, "0912695680" });

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Balance",
                value: 9000.0);

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Balance",
                value: 12800.0);

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"),
                column: "Balance",
                value: 47500.0);

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "Amount", "WalletBalance" },
                values: new object[] { 10000.0, 100000.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "Amount", "Type", "WalletBalance" },
                values: new object[] { -50000.0, 0, 50000.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "Amount", "Type", "WalletBalance" },
                values: new object[] { 60000.0, 1, 110000.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "Amount", "WalletBalance" },
                values: new object[] { 10000.0, 10000.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "Amount", "CreatedOn", "WalletBalance" },
                values: new object[] { 100000.0, new DateTime(2024, 1, 1, 12, 40, 28, 901, DateTimeKind.Local), 100000.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "Amount", "CreatedOn", "Type", "WalletBalance" },
                values: new object[] { -80000.0, new DateTime(2024, 1, 4, 1, 30, 15, 567, DateTimeKind.Local), 0, 8000.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"),
                columns: new[] { "Amount", "CreatedOn", "Type", "WalletBalance" },
                values: new object[] { 42000.0, new DateTime(2024, 1, 4, 12, 40, 28, 901, DateTimeKind.Local), 1, 50000.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"),
                columns: new[] { "Amount", "CreatedOn", "WalletBalance" },
                values: new object[] { 70000.0, new DateTime(2024, 1, 1, 12, 37, 42, 345, DateTimeKind.Local), 70000.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"),
                columns: new[] { "Amount", "WalletBalance" },
                values: new object[] { 10000.0, 10000.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"));

            migrationBuilder.DeleteData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"));

            migrationBuilder.DeleteData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"));

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "CreatedBy",
                value: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreatedBy", "CreatedOn", "Price", "WalletBalance" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2024, 1, 13, 22, 30, 3, 678, DateTimeKind.Local), 12000.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "AssetId", "CreatedBy", "CreatedOn", "Detail", "Fee", "Price", "ToAccountId", "WalletBalance" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000010"), new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2024, 1, 15, 9, 59, 59, 0, DateTimeKind.Local), "Mở khóa tài nguyên \"File PTS tuyển tập minh hoạ sách tâm lý\"", 0.0, 20000.0, new Guid("00000000-0000-0000-0000-000000000002"), 0.0 });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "AssetId", "CreatedBy", "CreatedOn", "Detail", "Price", "ToAccountId", "WalletBalance" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 1, 14, 22, 30, 3, 678, DateTimeKind.Local), "Mở khóa tài nguyên \"Ảnh cánh cụt\"", 20000.0, new Guid("00000000-0000-0000-0000-000000000005"), 0.0 });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                columns: new[] { "CreatedBy", "CreatedOn", "Detail", "Fee", "Price", "ToAccountId", "WalletBalance" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2024, 1, 3, 9, 59, 59, 0, DateTimeKind.Local), "	Đặt cọc thỏa thuận \"Làm web thiệp cưới\" (25%)", 0.0, 20000.0, new Guid("00000000-0000-0000-0000-000000000002"), 0.0 });

            migrationBuilder.InsertData(
                table: "TransactionHistory",
                columns: new[] { "Id", "AssetId", "CreatedBy", "CreatedOn", "Detail", "Fee", "Price", "ProposalId", "ToAccountId", "TransactionStatus", "WalletBalance" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000105"), null, new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2024, 2, 1, 9, 59, 59, 0, DateTimeKind.Local), "	Đặt cọc thỏa thuận \"Làm web thiệp cưới\" (25%)", 0.0, 20000.0, new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002"), 1, 0.0 });

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Balance",
                value: 2000000.0);

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Balance",
                value: 1000000.0);

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "Balance", "WithdrawInformation" },
                values: new object[] { 1000000.0, "0902287462" });

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Balance",
                value: 1000000.0);

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Balance",
                value: 1000000.0);

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"),
                column: "Balance",
                value: 0.0);

            migrationBuilder.InsertData(
                table: "Wallet",
                columns: new[] { "Id", "AccountId", "Balance", "WithdrawInformation", "WithdrawMethod" },
                values: new object[] { new Guid("00000000-0000-0000-0000-00000000000f"), new Guid("00000000-0000-0000-0000-00000000000f"), 0.0, "0365960823", 0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "Amount", "WalletBalance" },
                values: new object[] { 20000.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "Amount", "Type", "WalletBalance" },
                values: new object[] { 25000.0, 1, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "Amount", "Type", "WalletBalance" },
                values: new object[] { 20000.0, 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "Amount", "WalletBalance" },
                values: new object[] { 20000.0, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                columns: new[] { "Amount", "CreatedOn", "WalletBalance" },
                values: new object[] { 20000.0, new DateTime(2023, 11, 19, 12, 40, 28, 901, DateTimeKind.Local), 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "Amount", "CreatedOn", "Type", "WalletBalance" },
                values: new object[] { 250000.0, new DateTime(2023, 11, 29, 1, 30, 15, 567, DateTimeKind.Local), 1, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"),
                columns: new[] { "Amount", "CreatedOn", "Type", "WalletBalance" },
                values: new object[] { 170000.0, new DateTime(2023, 12, 10, 12, 40, 28, 901, DateTimeKind.Local), 0, 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"),
                columns: new[] { "Amount", "CreatedOn", "WalletBalance" },
                values: new object[] { 20000.0, new DateTime(2023, 11, 22, 12, 37, 42, 345, DateTimeKind.Local), 0.0 });

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"),
                columns: new[] { "Amount", "WalletBalance" },
                values: new object[] { 300000.0, 0.0 });

            migrationBuilder.InsertData(
                table: "WalletHistory",
                columns: new[] { "Id", "Amount", "AppTransId", "CreatedBy", "CreatedOn", "Fee", "PaymentMethod", "TransactionStatus", "Type", "WalletBalance" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000004"), 30000.0, "190815_3095728", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2023, 12, 10, 12, 40, 28, 901, DateTimeKind.Local), 0.0, 0, 1, 1, 0.0 },
                    { new Guid("00000000-0000-0000-0000-000000000006"), 250000.0, "231112_8023456", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2023, 11, 29, 1, 30, 15, 567, DateTimeKind.Local), 0.0, 0, 1, 1, 0.0 },
                    { new Guid("00000000-0000-0000-0000-000000000007"), 170000.0, "200925_6193840", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(2023, 12, 1, 6, 59, 59, 999, DateTimeKind.Local), 0.0, 0, 1, 0, 0.0 },
                    { new Guid("00000000-0000-0000-0000-00000000000c"), 250000.0, "200703_4567890", new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2023, 11, 15, 10, 45, 20, 123, DateTimeKind.Local), 0.0, 0, 1, 1, 0.0 },
                    { new Guid("00000000-0000-0000-0000-00000000000d"), 170000.0, "180924_1234567", new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2023, 12, 5, 9, 37, 42, 345, DateTimeKind.Local), 0.0, 0, 1, 0, 0.0 },
                    { new Guid("00000000-0000-0000-0000-00000000000f"), 150000.0, "220129_5678901", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2023, 11, 17, 9, 59, 59, 0, DateTimeKind.Local), 0.0, 0, 1, 0, 0.0 },
                    { new Guid("00000000-0000-0000-0000-000000000010"), 50000.0, "160827_3456789", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(2023, 11, 6, 1, 20, 45, 890, DateTimeKind.Local), 0.0, 0, 1, 1, 0.0 }
                });
        }
    }
}

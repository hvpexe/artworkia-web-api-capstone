using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Migrators.MSSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddInitV4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000015") });

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                column: "Price",
                value: 0.0);

            migrationBuilder.InsertData(
                table: "Asset",
                columns: new[] { "Id", "ArtworkId", "AssetName", "AssetTitle", "ContentType", "DeletedBy", "DeletedOn", "Description", "LastModificatedBy", "Location", "Price", "Size" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000063"), new Guid("00000000-0000-0000-0000-00000000001b"), "CommercialAsset.rar", "Ảnh gốc", "rar", null, null, "File PTS, tùy ý chỉnh sửa", null, "https://storage.cloud.google.com/artworkia-storage/Asset/CommercialAsset.rar?authuser=4", 0.0, 8000000m },
                    { new Guid("00000000-0000-0000-0000-000000000068"), new Guid("00000000-0000-0000-0000-000000000021"), "CommercialAsset.rar", "Ảnh gốc", "rar", null, null, "File PTS, tùy ý chỉnh sửa", null, "https://storage.cloud.google.com/artworkia-storage/Asset/CommercialAsset.rar?authuser=4", 0.0, 8000000m },
                    { new Guid("00000000-0000-0000-0000-000000000069"), new Guid("00000000-0000-0000-0000-000000000022"), "CommercialAsset.rar", "Ảnh gốc (xóa)", "rar", new Guid("00000000-0000-0000-0000-000000000018"), new DateTime(2024, 1, 3, 15, 20, 45, 890, DateTimeKind.Local), "File PTS, tùy ý chỉnh sửa", null, "https://storage.cloud.google.com/artworkia-storage/Asset/CommercialAsset.rar?authuser=4", 20000.0, 8000000m },
                    { new Guid("00000000-0000-0000-0000-00000000006a"), new Guid("00000000-0000-0000-0000-000000000022"), "CommercialAsset.rar", "Ảnh gốc (thêm)", "rar", null, null, "File PTS, tùy ý chỉnh sửa", null, "https://storage.cloud.google.com/artworkia-storage/Asset/CommercialAsset.rar?authuser=4", 25000.0, 8000000m },
                    { new Guid("00000000-0000-0000-0000-000000000091"), new Guid("00000000-0000-0000-0000-00000000003f"), "CommercialAsset.rar", "The Dragonborn Daedric Armor", "rar", null, null, "All file asset 3d model", null, "https://storage.cloud.google.com/artworkia-storage/Asset/CommercialAsset.rar?authuser=4", 0.0, 8000000m }
                });

            migrationBuilder.InsertData(
                table: "Notification",
                columns: new[] { "Id", "Content", "CreatedOn", "IsSeen", "NotifyType", "ReferencedAccountId", "ReferencedArtworkId", "SentToAccount" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-000000000008"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000009"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-00000000000a"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-00000000000a") },
                    { new Guid("00000000-0000-0000-0000-00000000000b"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-00000000000b") },
                    { new Guid("00000000-0000-0000-0000-00000000000c"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-00000000000c") },
                    { new Guid("00000000-0000-0000-0000-00000000000d"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-00000000000d") },
                    { new Guid("00000000-0000-0000-0000-00000000000e"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-00000000000e") },
                    { new Guid("00000000-0000-0000-0000-00000000000f"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-00000000000f") },
                    { new Guid("00000000-0000-0000-0000-000000000010"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("00000000-0000-0000-0000-000000000012"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000000-0000-0000-0000-000000000013"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000000-0000-0000-0000-000000000014"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-000000000014") },
                    { new Guid("00000000-0000-0000-0000-000000000015"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-000000000015") },
                    { new Guid("00000000-0000-0000-0000-000000000016"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-000000000016") },
                    { new Guid("00000000-0000-0000-0000-000000000017"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-000000000017") },
                    { new Guid("00000000-0000-0000-0000-000000000018"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-000000000018") },
                    { new Guid("00000000-0000-0000-0000-000000000019"), "Chào mừng đến với Artworkia", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 0, null, null, new Guid("00000000-0000-0000-0000-000000000019") },
                    { new Guid("00000000-0000-0000-0000-00000000001a"), "Cảnh báo bảo mật", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 1, null, null, new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0000-00000000001b"), "Người dùng [hoanganh] vừa theo dõi bạn", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, null, new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0000-00000000001c"), "Người dùng [lamlam] vừa theo dõi bạn", new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, 2, null, null, new Guid("00000000-0000-0000-0000-000000000005") }
                });

            migrationBuilder.InsertData(
                table: "TagDetail",
                columns: new[] { "ArtworkId", "TagId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000019") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-00000000001b") }
                });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "AssetId", "CreatedBy", "CreatedOn", "Detail", "Price", "ToAccountId", "WalletBalance" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000083"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2023, 12, 29, 22, 30, 3, 678, DateTimeKind.Local), "Mở khóa tài nguyên \"Pixel Art GUI / UI Kit + 151 icons!\"", -150000.0, new Guid("00000000-0000-0000-0000-00000000000a"), 850000.0 });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "AssetId", "CreatedBy", "CreatedOn", "Detail", "Fee", "Price", "ToAccountId", "WalletBalance" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000083"), new Guid("00000000-0000-0000-0000-00000000000a"), new DateTime(2024, 12, 29, 22, 30, 3, 678, DateTimeKind.Local), "Mở khóa tài nguyên \"Pixel Art GUI / UI Kit + 151 icons!\"", 7500.0, 142500.0, new Guid("00000000-0000-0000-0000-000000000005"), 142500.0 });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreatedOn", "WalletBalance" },
                values: new object[] { new DateTime(2024, 12, 29, 22, 30, 3, 678, DateTimeKind.Local), 21000.0 });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "WalletBalance",
                value: 148000.0);

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "WalletBalance",
                value: 128000.0);

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "WalletBalance",
                value: 81000.0);

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "WalletBalance",
                value: 31000.0);

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedBy", "CreatedOn", "Detail", "Price", "ToAccountId", "WalletBalance" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2024, 1, 1, 22, 30, 3, 678, DateTimeKind.Local), "Mở khóa tài nguyên \"Dấu vết của quá khứ\"", -10000.0, new Guid("00000000-0000-0000-0000-000000000002"), 21000.0 });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "AssetId", "CreatedBy", "CreatedOn", "Detail", "Fee", "Price", "ToAccountId", "WalletBalance" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 1, 1, 22, 30, 3, 678, DateTimeKind.Local), "Mở khóa tài nguyên \"Dấu vết của quá khứ\"", 500.0, 9500.0, new Guid("00000000-0000-0000-0000-000000000005"), 119500.0 });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                column: "WalletBalance",
                value: 730000.0);

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                column: "WalletBalance",
                value: 138500.0);

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                column: "WalletBalance",
                value: 670000.0);

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                column: "WalletBalance",
                value: 185000.0);

            migrationBuilder.InsertData(
                table: "TransactionHistory",
                columns: new[] { "Id", "AssetId", "CreatedBy", "CreatedOn", "Detail", "Fee", "Price", "ProposalId", "ToAccountId", "TransactionStatus", "WalletBalance" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000080"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2024, 1, 2, 22, 30, 3, 678, DateTimeKind.Local), "Mở khóa tài nguyên \"Figma Full\"", 0.0, -90000.0, null, new Guid("00000000-0000-0000-0000-000000000012"), 1, 750000.0 },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new Guid("00000000-0000-0000-0000-000000000080"), new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(2024, 1, 2, 22, 30, 3, 678, DateTimeKind.Local), "Mở khóa tài nguyên \"Figma Full\"", 4500.0, 85500.0, null, new Guid("00000000-0000-0000-0000-000000000005"), 1, 85500.0 }
                });

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Balance",
                value: 185000.0);

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Balance",
                value: 21000.0);

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Balance",
                value: 670000.0);

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"),
                column: "Balance",
                value: 142500.0);

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Balance",
                value: 85500.0);

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "WalletBalance",
                value: 20000.0);

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"),
                column: "WalletBalance",
                value: 62000.0);

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"),
                columns: new[] { "Amount", "CreatedOn", "WalletBalance" },
                values: new object[] { 1000000.0, new DateTime(2023, 12, 20, 12, 37, 42, 345, DateTimeKind.Local), 1000000.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000063"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000068"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000069"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000006a"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000091"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000c"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000d"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000f"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000001a"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000001b"));

            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000001c"));

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000019") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-00000000001b") });

            migrationBuilder.DeleteData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"),
                column: "Price",
                value: 20000.0);

            migrationBuilder.InsertData(
                table: "TagDetail",
                columns: new[] { "ArtworkId", "TagId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000015") });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "AssetId", "CreatedBy", "CreatedOn", "Detail", "Price", "ToAccountId", "WalletBalance" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2024, 1, 2, 22, 30, 3, 678, DateTimeKind.Local), "Mở khóa tài nguyên \"Ảnh cánh cụt\"", -12000.0, new Guid("00000000-0000-0000-0000-000000000005"), 88000.0 });

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
                columns: new[] { "CreatedOn", "WalletBalance" },
                values: new object[] { new DateTime(2024, 1, 5, 22, 30, 3, 678, DateTimeKind.Local), 40000.0 });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "WalletBalance",
                value: 119500.0);

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "WalletBalance",
                value: 99500.0);

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "WalletBalance",
                value: 59000.0);

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "WalletBalance",
                value: 9000.0);

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreatedBy", "CreatedOn", "Detail", "Price", "ToAccountId", "WalletBalance" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(2024, 1, 14, 22, 30, 3, 678, DateTimeKind.Local), "Mở khóa tài nguyên \"Ảnh cánh cụt\"", -12000.0, new Guid("00000000-0000-0000-0000-000000000005"), 87500.0 });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                columns: new[] { "AssetId", "CreatedBy", "CreatedOn", "Detail", "Fee", "Price", "ToAccountId", "WalletBalance" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000030"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2024, 1, 14, 22, 30, 3, 678, DateTimeKind.Local), "Mở khóa tài nguyên \"Ảnh cánh cụt\"", 600.0, 11400.0, new Guid("00000000-0000-0000-0000-000000000002"), 92800.0 });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"),
                column: "WalletBalance",
                value: 72800.0);

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000102"),
                column: "WalletBalance",
                value: 106500.0);

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000103"),
                column: "WalletBalance",
                value: 12800.0);

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000104"),
                column: "WalletBalance",
                value: 163500.0);

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Balance",
                value: 163500.0);

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
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"),
                column: "Balance",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "Balance",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "WalletBalance",
                value: 8000.0);

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"),
                column: "WalletBalance",
                value: 50000.0);

            migrationBuilder.UpdateData(
                table: "WalletHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"),
                columns: new[] { "Amount", "CreatedOn", "WalletBalance" },
                values: new object[] { 70000.0, new DateTime(2024, 1, 1, 12, 37, 42, 345, DateTimeKind.Local), 70000.0 });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Migrators.MSSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddInitV7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Avatar",
                value: "https://i.pinimg.com/564x/db/02/67/db02679d039a230d9a37caec679d1b3b.jpg");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Avatar",
                value: "https://i.pinimg.com/originals/4b/59/75/4b5975b01115a778a6d8016bf4d0ddc7.jpg");

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Thumbnail",
                value: "https://i.pinimg.com/564x/61/59/6c/61596cae1a6dc2dede171e59fb5787aa.jpg");

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Thumbnail",
                value: "https://i.pinimg.com/originals/8d/97/66/8d9766d16e7cf36ade29a0e307ce81be.jpg");

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "Reason", "ReportType", "State" },
                values: new object[] { "Ảnh AI", 4, 1 });

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "Note", "Reason", "ReportType" },
                values: new object[] { "Đã cảnh cáo", "Nội dung không phù hợp", 4 });

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "Note", "Reason", "ReportType" },
                values: new object[] { "Đã kiểm tra", "Không thuộc về tác giả", 3 });

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "Reason", "State" },
                values: new object[] { "Nội dung không cho phép", 1 });

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "Reason", "State" },
                values: new object[] { "Ảnh AI", 2 });

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "Reason", "State" },
                values: new object[] { "Không có nghệ thuật", 2 });

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "Reason", "State" },
                values: new object[] { "Đây là spam", 1 });

            migrationBuilder.InsertData(
                table: "Report",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Note", "Reason", "ReportEntity", "ReportType", "State", "TargetId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000100"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2024, 1, 1, 15, 40, 28, 901, DateTimeKind.Local), null, "Tài khoản spam", 0, 2, 2, new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000101"), new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(2024, 1, 2, 15, 40, 28, 901, DateTimeKind.Local), null, "Tài khoản đăng tác phẩm trùng lặp", 0, 4, 1, new Guid("00000000-0000-0000-0000-000000000017") }
                });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "AssetId", "WalletBalance" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), 840000.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Report",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000100"));

            migrationBuilder.DeleteData(
                table: "Report",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000101"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Avatar",
                value: "https://i.pinimg.com/564x/14/b0/3b/14b03bdcab41f458dd15c9f5669cef2d.jpg");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Avatar",
                value: "https://i.pinimg.com/564x/79/ba/4f/79ba4f6c73168efb975a2d43cc4272a3.jpg");

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Thumbnail",
                value: "https://th.bing.com/th/id/OIG..gPcXaRan.FdnEjYCvT3?pid=ImgGn");

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "Thumbnail",
                value: "https://th.bing.com/th/id/OIG.Uz66_wn15hsKPirpv6Pb?pid=ImgGn");

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                columns: new[] { "Reason", "ReportType", "State" },
                values: new object[] { "this is sexual harrasment", 0, 0 });

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "Note", "Reason", "ReportType" },
                values: new object[] { "This is impersonation", "Inappropriate content", 3 });

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "Note", "Reason", "ReportType" },
                values: new object[] { "This is not abuse of platform", "Abuse of platform", 0 });

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "Reason", "State" },
                values: new object[] { "Disallowed content", 0 });

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "Reason", "State" },
                values: new object[] { "Disallowed content", 0 });

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                columns: new[] { "Reason", "State" },
                values: new object[] { "Not suitable", 0 });

            migrationBuilder.UpdateData(
                table: "Report",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                columns: new[] { "Reason", "State" },
                values: new object[] { "This is spam", 0 });

            migrationBuilder.UpdateData(
                table: "TransactionHistory",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                columns: new[] { "AssetId", "WalletBalance" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000030"), 21000.0 });
        }
    }
}

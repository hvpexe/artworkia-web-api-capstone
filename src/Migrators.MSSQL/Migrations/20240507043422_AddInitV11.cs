using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddInitV11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "Bio", "Email", "Fullname", "Username" },
                values: new object[] { "tôi là một nghệ sĩ đầy tài năng", "ngocphien@example.com", "Ngọc Phiên", "ngocphien" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "Bio", "Email", "Fullname", "Username" },
                values: new object[] { "tôi là một nghệ sĩ đầy tài năng", "nguyennguyen@example.com", "Nguyễn Nguyễn", "nguyennguyen" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "Bio", "Email", "Fullname", "Username" },
                values: new object[] { "tôi là một nghệ sĩ đầy tài năng", "minhvuong@example.com", "Trần Minh Vương", "minhvuong" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                column: "Password",
                value: "sTtIwLGpc7aHdsPGLBcoewBrPUKZOWaKdWFbt5BtAWwfYM2E");

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                column: "Balance",
                value: 5000000.0);

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                column: "Balance",
                value: 5000000.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                columns: new[] { "Bio", "Email", "Fullname", "Username" },
                values: new object[] { "Tôi là Trúc Lam Võ, tôi là một nghệ sĩ đầy tài năng", "lamlam@example.com", "Trúc Lam Võ", "lamlam" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                columns: new[] { "Bio", "Email", "Fullname", "Username" },
                values: new object[] { "Tôi là Đặng Hoàng Anh, tôi là một nghệ sĩ đầy tài năng", "anhdhse160846@fpt.edu.vn", "Đặng Hoàng Anh", "hoanganh" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                columns: new[] { "Bio", "Email", "Fullname", "Username" },
                values: new object[] { "Tôi là Nguyễn Trung Thông, tôi là một nghệ sĩ đầy tài năng", "thong@example.com", "Nguyễn Trung Thông", "thong" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                column: "Password",
                value: "mvCUau3J+IMoyq0xUVyjWWVxeqb9/dDm6J6udBpDkUUWqMUZ");

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                column: "Balance",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Wallet",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                column: "Balance",
                value: 0.0);
        }
    }
}

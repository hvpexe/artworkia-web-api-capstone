using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddInitV10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "Bio", "Email", "Fullname", "Username" },
                values: new object[] { "", "trieuhan@gmail.com", "Triệu Ngọc Hân", "trieuhan" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "Avatar", "Password" },
                values: new object[] { "https://scontent.fsgn5-15.fna.fbcdn.net/v/t39.30808-6/435670863_1846947755754490_8269400988884068525_n.jpg?_nc_cat=111&ccb=1-7&_nc_sid=5f2048&_nc_eui2=AeGtVla0aFp8GQpYdHlvHPoBXBMoLXmitndcEygteaK2d_IE6Bsv4sjggWL8GWzMnbQ6cO0QOBUAlbeVenCd9Vb_&_nc_ohc=rx2PrR5abt4Q7kNvgEva5Q1&_nc_ht=scontent.fsgn5-15.fna&oh=00_AfCPsoKdAw2gAGCA5n_F24XaQcK14oAbWmtYlFKgWhB6Gw&oe=663E943A", "mvCUau3J+IMoyq0xUVyjWWVxeqb9/dDm6J6udBpDkUUWqMUZ" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "Fullname", "Password" },
                values: new object[] { "Mạnh", "sTtIwLGpc7aHdsPGLBcoewBrPUKZOWaKdWFbt5BtAWwfYM2E" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                columns: new[] { "Bio", "Email", "Fullname", "Username" },
                values: new object[] { "Tôi là Huỳnh Vạn Phú, tôi là một nghệ sĩ đầy tài năng", "phuhuynh923@gmail.com", "Huỳnh Vạn Phú", "phuhuynh" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000018"),
                columns: new[] { "Avatar", "Password" },
                values: new object[] { "https://i.pinimg.com/564x/af/65/88/af6588a1cb6be3602190e4c223b79318.jpg", "A5tzNn90k1cgMCIWicwomDz/Wb1/BAWIDIVelEKhM6lHvuwh" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000019"),
                columns: new[] { "Fullname", "Password" },
                values: new object[] { "Nguyễn Đức Mạnh", "A5tzNn90k1cgMCIWicwomDz/Wb1/BAWIDIVelEKhM6lHvuwh" });
        }
    }
}

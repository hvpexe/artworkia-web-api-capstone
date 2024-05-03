using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddInitV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Password",
                value: "A5tzNn90k1cgMCIWicwomDz/Wb1/BAWIDIVelEKhM6lHvuwh");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Password",
                value: "A5tzNn90k1cgMCIWicwomDz/Wb1/BAWIDIVelEKhM6lHvuwh");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Password",
                value: "A5tzNn90k1cgMCIWicwomDz/Wb1/BAWIDIVelEKhM6lHvuwh");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Password",
                value: "A5tzNn90k1cgMCIWicwomDz/Wb1/BAWIDIVelEKhM6lHvuwh");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Password",
                value: "A5tzNn90k1cgMCIWicwomDz/Wb1/BAWIDIVelEKhM6lHvuwh");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Password",
                value: "A5tzNn90k1cgMCIWicwomDz/Wb1/BAWIDIVelEKhM6lHvuwh");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Password",
                value: "A5tzNn90k1cgMCIWicwomDz/Wb1/BAWIDIVelEKhM6lHvuwh");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"),
                column: "Password",
                value: "/Yvo/zNSPcJB+6Roi0BD6gR/tx9tPXSqrslB+3Zy0rwOC2lA");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"),
                column: "Password",
                value: "P9i8PUWQ4DnT6Dnstg7HEXTlnFUDoZFTNJopEJ4UxxoK3zRn");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Password",
                value: "RZX95v+qA/O+EKXLkilrMbLW+cKQ7jekrOE9uwWE4fSupbQM");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"),
                column: "Password",
                value: "BCpA8roVqTkU54PKIBXU4Iyl3YqyF5wYPagAXZ/1HYFEB9dh");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Password",
                value: "44p9oaVq2ED8i7Q6vKIaS//ynDYqhnLcHcX/W7sDDIa1m3v/");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "Password",
                value: "/yI89eEokmyCtc8FQcA8Salpuc2Gnv6+xvWUi9jfF3D56K8l");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "Password",
                value: "tmb/sYLga1PDxUtRiIEU4YJtaG2HN58av/VA2S/8v19GLbSx");
        }
    }
}

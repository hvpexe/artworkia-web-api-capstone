using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddInitV5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "DeliveryTime", "Description", "LastModificatedBy", "NumberOfConcept", "NumberOfRevision", "ServiceName", "StartingPrice", "Thumbnail" },
                values: new object[] { new Guid("00000000-0000-0000-0000-00000000000b"), new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "1 - 2 tháng", "Dịch vụ thiết kế bìa sách theo yêu cầu", null, 2, 2, "Thiết kế bìa sách", 80000.0, "https://cms.typenetwork.com/media/original_images/banner_KvvXKmF.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000b"));
        }
    }
}

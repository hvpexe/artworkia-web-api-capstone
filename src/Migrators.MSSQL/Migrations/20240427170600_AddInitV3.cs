using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Migrators.MSSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddInitV3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-00000000000b") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000011") });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Email",
                value: "anhdhse160846@fpt.edu.vn");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Email",
                value: "phuhuynh923@gmail.com");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Email",
                value: "trieuhan282@gmail.com");

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"),
                columns: new[] { "Thumbnail", "ViewCount" },
                values: new object[] { "https://i.pinimg.com/564x/98/08/55/980855dafc9c24ad9b0687adb4b29f0b.jpg", 1934 });

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "CreatedOn",
                value: new DateTime(2023, 11, 10, 15, 30, 3, 678, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                column: "IsAIGenerated",
                value: true);

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000004b"),
                column: "IsAIGenerated",
                value: true);

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000004c"),
                column: "IsAIGenerated",
                value: true);

            migrationBuilder.InsertData(
                table: "Artwork",
                columns: new[] { "Id", "CommentCount", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "Description", "IsAIGenerated", "LastModificatedBy", "LicenseTypeId", "LikeCount", "Note", "Privacy", "State", "Thumbnail", "ThumbnailName", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-00000000004f"), 0, new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(2024, 1, 25, 15, 30, 3, 678, DateTimeKind.Local), null, null, "Chính chủ bán BT Phong Lan 04 - 34. DT 343.8m² nhà thô, sông sau nhà rộng miên man. Sân trước nhà 1000m.\r\n                                Hướng Tây Nam.\r\n                                Giá 220tr/m².", false, null, new Guid("00000000-0000-0000-0000-000000000001"), 0, null, 0, 1, "https://file4.batdongsan.com.vn/resize/1275x717/2024/03/07/20240307144316-1cca_wm.jpg", "00000000-0000-0000-0000-00000000004f_t.jpg", "Chính chủ bán BT Phong Lan 04-34, 343.8m2 nhà thô, sông sau nhà rộng miên man, sân trước nhà 1000m2", 110 },
                    { new Guid("00000000-0000-0000-0000-000000000050"), 0, new Guid("00000000-0000-0000-0000-000000000015"), new DateTime(2024, 3, 5, 15, 30, 3, 678, DateTimeKind.Local), null, null, null, false, null, new Guid("00000000-0000-0000-0000-000000000001"), 0, null, 0, 1, "https://i.pinimg.com/originals/86/15/50/8615509334c99ba0c11a9feac151a79e.jpg", "00000000-0000-0000-0000-000000000050_t.jpg", "Mèo con", 1160 }
                });

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                column: "ArtworkId",
                value: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.InsertData(
                table: "Asset",
                columns: new[] { "Id", "ArtworkId", "AssetName", "AssetTitle", "ContentType", "DeletedBy", "DeletedOn", "Description", "LastModificatedBy", "Location", "Price", "Size" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000031"), new Guid("00000000-0000-0000-0000-00000000000f"), "CommercialAsset.rar", "Ảnh cánh cụt khác", "rar", null, null, "Tổng hợp cánh cụt fullsize", null, "https://storage.cloud.google.com/artworkia-storage/Asset/CommercialAsset.rar?authuser=4", 12000.0, 8000000m },
                    { new Guid("00000000-0000-0000-0000-000000000085"), new Guid("00000000-0000-0000-0000-000000000048"), "CommercialAsset.rar", "Background Fullsize", "rar", null, null, "Original PNG", null, "https://storage.cloud.google.com/artworkia-storage/Asset/CommercialAsset.rar?authuser=4", 20000.0, 8000000m },
                    { new Guid("00000000-0000-0000-0000-000000000090"), new Guid("00000000-0000-0000-0000-00000000004d"), "CommercialAsset.rar", "Logo Asset", "rar", null, null, "Original PNG", null, "https://storage.cloud.google.com/artworkia-storage/Asset/CommercialAsset.rar?authuser=4", 10000.0, 8000000m }
                });

            migrationBuilder.InsertData(
                table: "CategoryArtworkDetail",
                columns: new[] { "ArtworkId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000041"), new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-00000000003e"), new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-00000000003f"), new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000040"), new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000045"), new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000046"), new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000047"), new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-00000000004d"), new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000046"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000022"), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-00000000004d"), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-00000000003e"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-00000000003f"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000040"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000045"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-00000000004e"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000046"), new Guid("00000000-0000-0000-0000-00000000000b") },
                    { new Guid("00000000-0000-0000-0000-000000000047"), new Guid("00000000-0000-0000-0000-00000000000b") },
                    { new Guid("00000000-0000-0000-0000-00000000004d"), new Guid("00000000-0000-0000-0000-00000000000b") },
                    { new Guid("00000000-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-00000000000c") },
                    { new Guid("00000000-0000-0000-0000-000000000042"), new Guid("00000000-0000-0000-0000-00000000000d") },
                    { new Guid("00000000-0000-0000-0000-000000000043"), new Guid("00000000-0000-0000-0000-00000000000d") },
                    { new Guid("00000000-0000-0000-0000-000000000044"), new Guid("00000000-0000-0000-0000-00000000000d") },
                    { new Guid("00000000-0000-0000-0000-00000000003e"), new Guid("00000000-0000-0000-0000-00000000000e") },
                    { new Guid("00000000-0000-0000-0000-00000000003f"), new Guid("00000000-0000-0000-0000-00000000000e") },
                    { new Guid("00000000-0000-0000-0000-000000000040"), new Guid("00000000-0000-0000-0000-00000000000e") }
                });

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                column: "Location",
                value: "https://i.pinimg.com/564x/98/08/55/980855dafc9c24ad9b0687adb4b29f0b.jpg");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                column: "Location",
                value: "https://i.pinimg.com/originals/b5/7e/14/b57e14aa401d41db2072d1b0ccfbde2b.jpg");

            migrationBuilder.InsertData(
                table: "Service",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "DeletedBy", "DeletedOn", "DeliveryTime", "Description", "LastModificatedBy", "NumberOfConcept", "NumberOfRevision", "ServiceName", "StartingPrice", "Thumbnail" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000009"), new Guid("00000000-0000-0000-0000-000000000014"), new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "1 - 2 tuần", "Mang đến sức sống cho những thế giới ảo diệu! Bạn đang tìm kiếm dịch vụ thiết kế nhân vật game 3D chất lượng cao để nâng tầm dự án của mình ? Hãy đến với chúng tôi!", null, 1, 2, "Thiết kế đồ họa Cyberpunk", 40000.0, "https://www.cyberpunk.net/build/images/pre-order/buy-b/keyart-ue-en@2x-cd66fd0d.jpg" },
                    { new Guid("00000000-0000-0000-0000-00000000000a"), new Guid("00000000-0000-0000-0000-00000000000c"), new DateTime(2024, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "1 - 2 tuần", "Chuyên gia thiết kế logo cho các trò chơi, nhãn hàng", null, 2, 2, "Thiết kế logo thương hiệu", 60000.0, "https://digihubmedia.in/wp-content/uploads/2021/05/logo-design-service-in-sangli-pune-scaled.jpg" }
                });

            migrationBuilder.InsertData(
                table: "SoftwareDetail",
                columns: new[] { "ArtworkId", "SoftwareUsedId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-00000000004e"), new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-00000000004d"), new Guid("00000000-0000-0000-0000-000000000002") },
                    { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000039") },
                    { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000039") },
                    { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000039") }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "TagName" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000028"), "Logo" });

            migrationBuilder.InsertData(
                table: "TagDetail",
                columns: new[] { "ArtworkId", "TagId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-00000000004d"), new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000000-0000-0000-0000-00000000004e"), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-00000000004d"), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-00000000004e"), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("00000000-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-00000000000a") },
                    { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-00000000000b") },
                    { new Guid("00000000-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-00000000000b") },
                    { new Guid("00000000-0000-0000-0000-00000000004d"), new Guid("00000000-0000-0000-0000-00000000000b") },
                    { new Guid("00000000-0000-0000-0000-00000000004e"), new Guid("00000000-0000-0000-0000-00000000000b") },
                    { new Guid("00000000-0000-0000-0000-00000000004e"), new Guid("00000000-0000-0000-0000-00000000000f") },
                    { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000017") },
                    { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000017") },
                    { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000017") },
                    { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000019") },
                    { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000019") },
                    { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000019") },
                    { new Guid("00000000-0000-0000-0000-00000000004e"), new Guid("00000000-0000-0000-0000-00000000001a") },
                    { new Guid("00000000-0000-0000-0000-00000000004e"), new Guid("00000000-0000-0000-0000-00000000001c") },
                    { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-00000000001e") },
                    { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000021") },
                    { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000021") },
                    { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000021") },
                    { new Guid("00000000-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-000000000022") },
                    { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000023") },
                    { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000023") },
                    { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000023") },
                    { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000024") },
                    { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000024") },
                    { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000024") },
                    { new Guid("00000000-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-000000000026") }
                });

            migrationBuilder.InsertData(
                table: "CategoryArtworkDetail",
                columns: new[] { "ArtworkId", "CategoryId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000001") },
                    { new Guid("00000000-0000-0000-0000-00000000004f"), new Guid("00000000-0000-0000-0000-000000000004") },
                    { new Guid("00000000-0000-0000-0000-00000000004f"), new Guid("00000000-0000-0000-0000-00000000000a") }
                });

            migrationBuilder.InsertData(
                table: "Image",
                columns: new[] { "Id", "ArtworkId", "ImageHash", "ImageName", "LastModificatedBy", "LastModificatedOn", "Location", "Order" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-0000000000a0"), new Guid("00000000-0000-0000-0000-00000000004f"), null, "00000000-0000-0000-0000-00000000004f_i0.jpg", null, null, "https://file4.batdongsan.com.vn/2024/03/07/20240307144316-1cca_wm.jpg", 0 },
                    { new Guid("00000000-0000-0000-0000-0000000000a1"), new Guid("00000000-0000-0000-0000-00000000004f"), null, "00000000-0000-0000-0000-00000000004f_i1.jpg", null, null, "https://file4.batdongsan.com.vn/2024/03/07/20240307144319-ee94_wm.jpg", 1 },
                    { new Guid("00000000-0000-0000-0000-0000000000a2"), new Guid("00000000-0000-0000-0000-00000000004f"), null, "00000000-0000-0000-0000-00000000004f_i2.jpg", null, null, "https://file4.batdongsan.com.vn/2024/03/07/20240307144319-f0da_wm.jpg", 2 },
                    { new Guid("00000000-0000-0000-0000-0000000000a3"), new Guid("00000000-0000-0000-0000-000000000050"), null, "00000000-0000-0000-0000-000000000050_i0.jpg", null, null, "https://i.pinimg.com/originals/86/15/50/8615509334c99ba0c11a9feac151a79e.jpg", 0 }
                });

            migrationBuilder.InsertData(
                table: "SoftwareDetail",
                columns: new[] { "ArtworkId", "SoftwareUsedId" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.InsertData(
                table: "TagDetail",
                columns: new[] { "ArtworkId", "TagId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-00000000004f"), new Guid("00000000-0000-0000-0000-000000000003") },
                    { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000014") },
                    { new Guid("00000000-0000-0000-0000-00000000004f"), new Guid("00000000-0000-0000-0000-000000000018") },
                    { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000019") },
                    { new Guid("00000000-0000-0000-0000-00000000004f"), new Guid("00000000-0000-0000-0000-00000000001d") },
                    { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000026") },
                    { new Guid("00000000-0000-0000-0000-00000000004d"), new Guid("00000000-0000-0000-0000-000000000028") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000031"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000085"));

            migrationBuilder.DeleteData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000090"));

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000041"), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000003e"), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000003f"), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000040"), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000045"), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000046"), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000047"), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004d"), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000046"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004f"), new Guid("00000000-0000-0000-0000-000000000004") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000022"), new Guid("00000000-0000-0000-0000-000000000006") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000007") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004d"), new Guid("00000000-0000-0000-0000-000000000007") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000003e"), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000003f"), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000040"), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000045"), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000009") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000009") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000009") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004e"), new Guid("00000000-0000-0000-0000-000000000009") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004f"), new Guid("00000000-0000-0000-0000-00000000000a") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000046"), new Guid("00000000-0000-0000-0000-00000000000b") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000047"), new Guid("00000000-0000-0000-0000-00000000000b") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004d"), new Guid("00000000-0000-0000-0000-00000000000b") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-00000000000c") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000042"), new Guid("00000000-0000-0000-0000-00000000000d") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000043"), new Guid("00000000-0000-0000-0000-00000000000d") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000044"), new Guid("00000000-0000-0000-0000-00000000000d") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000003e"), new Guid("00000000-0000-0000-0000-00000000000e") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000003f"), new Guid("00000000-0000-0000-0000-00000000000e") });

            migrationBuilder.DeleteData(
                table: "CategoryArtworkDetail",
                keyColumns: new[] { "ArtworkId", "CategoryId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000040"), new Guid("00000000-0000-0000-0000-00000000000e") });

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-0000000000a0"));

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-0000000000a1"));

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-0000000000a2"));

            migrationBuilder.DeleteData(
                table: "Image",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-0000000000a3"));

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Service",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000a"));

            migrationBuilder.DeleteData(
                table: "SoftwareDetail",
                keyColumns: new[] { "ArtworkId", "SoftwareUsedId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.DeleteData(
                table: "SoftwareDetail",
                keyColumns: new[] { "ArtworkId", "SoftwareUsedId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004e"), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.DeleteData(
                table: "SoftwareDetail",
                keyColumns: new[] { "ArtworkId", "SoftwareUsedId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.DeleteData(
                table: "SoftwareDetail",
                keyColumns: new[] { "ArtworkId", "SoftwareUsedId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004d"), new Guid("00000000-0000-0000-0000-000000000002") });

            migrationBuilder.DeleteData(
                table: "SoftwareDetail",
                keyColumns: new[] { "ArtworkId", "SoftwareUsedId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000007") });

            migrationBuilder.DeleteData(
                table: "SoftwareDetail",
                keyColumns: new[] { "ArtworkId", "SoftwareUsedId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000039") });

            migrationBuilder.DeleteData(
                table: "SoftwareDetail",
                keyColumns: new[] { "ArtworkId", "SoftwareUsedId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000039") });

            migrationBuilder.DeleteData(
                table: "SoftwareDetail",
                keyColumns: new[] { "ArtworkId", "SoftwareUsedId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000039") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004d"), new Guid("00000000-0000-0000-0000-000000000001") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004f"), new Guid("00000000-0000-0000-0000-000000000003") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000005") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-000000000006") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004e"), new Guid("00000000-0000-0000-0000-000000000007") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004d"), new Guid("00000000-0000-0000-0000-000000000008") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000009") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000009") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000009") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000009") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004e"), new Guid("00000000-0000-0000-0000-000000000009") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-00000000000a") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-00000000000b") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-00000000000b") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004d"), new Guid("00000000-0000-0000-0000-00000000000b") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004e"), new Guid("00000000-0000-0000-0000-00000000000b") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004e"), new Guid("00000000-0000-0000-0000-00000000000f") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-000000000012") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000013") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000013") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000014") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000017") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000017") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000017") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004f"), new Guid("00000000-0000-0000-0000-000000000018") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000019") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000019") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000019") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000019") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004e"), new Guid("00000000-0000-0000-0000-00000000001a") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004e"), new Guid("00000000-0000-0000-0000-00000000001c") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004f"), new Guid("00000000-0000-0000-0000-00000000001d") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000048"), new Guid("00000000-0000-0000-0000-00000000001e") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000021") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000021") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000021") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-000000000022") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000023") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000023") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000023") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004a"), new Guid("00000000-0000-0000-0000-000000000024") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004b"), new Guid("00000000-0000-0000-0000-000000000024") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004c"), new Guid("00000000-0000-0000-0000-000000000024") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000049"), new Guid("00000000-0000-0000-0000-000000000026") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000050"), new Guid("00000000-0000-0000-0000-000000000026") });

            migrationBuilder.DeleteData(
                table: "TagDetail",
                keyColumns: new[] { "ArtworkId", "TagId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-00000000004d"), new Guid("00000000-0000-0000-0000-000000000028") });

            migrationBuilder.DeleteData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000004f"));

            migrationBuilder.DeleteData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000050"));

            migrationBuilder.DeleteData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000028"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"),
                column: "Email",
                value: "hoanganh@example.com");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "Email",
                value: "phu@example.com");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "Email",
                value: "nguyenhoang@example.com");

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000000e"),
                columns: new[] { "Thumbnail", "ViewCount" },
                values: new object[] { "https://th.bing.com/th/id/OIG.D7FfBXsOQCjc28w68xZS?pid=ImgGn", 1234 });

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "CreatedOn",
                value: new DateTime(2024, 1, 10, 15, 30, 3, 678, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                column: "IsAIGenerated",
                value: false);

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000004b"),
                column: "IsAIGenerated",
                value: false);

            migrationBuilder.UpdateData(
                table: "Artwork",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-00000000004c"),
                column: "IsAIGenerated",
                value: false);

            migrationBuilder.UpdateData(
                table: "Asset",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000040"),
                column: "ArtworkId",
                value: new Guid("00000000-0000-0000-0000-00000000000f"));

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000020"),
                column: "Location",
                value: "https://i.pinimg.com/originals/b5/7e/14/b57e14aa401d41db2072d1b0ccfbde2b.jpg");

            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000021"),
                column: "Location",
                value: "https://i.pinimg.com/originals/04/b7/46/04b7460b2efef9c432dabbcda2507b71.jpg");

            migrationBuilder.InsertData(
                table: "TagDetail",
                columns: new[] { "ArtworkId", "TagId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-00000000000b") },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new Guid("00000000-0000-0000-0000-000000000011") }
                });
        }
    }
}

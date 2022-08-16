using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjektBerga.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 1, "aperture", "Grafičke kartice", "Grafičke kartice" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 2, "aperture", "Mobiteli", "Mobiteli" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 3, "aperture", "Slušalice", "Slušalice" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 14, 13, 15, 0, 672, DateTimeKind.Local).AddTicks(191), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " 2GB RAM", "https://www.hgspot.hr/image/cachewebp/catalog/slike/145204-878-640x480.webp", false, false, 3500m, 2500m, "XFX AMD Radeon RX 550" },
                    { 2, 1, new DateTime(2022, 8, 14, 13, 15, 0, 678, DateTimeKind.Local).AddTicks(6526), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " 2GB RAM", "https://www.instar-informatika.hr/slike/velike/11268-21-20g.jpg", false, false, 3500m, 2500m, "Sapphire Pulse AMD Radeon RX 550" },
                    { 3, 2, new DateTime(2022, 8, 14, 13, 15, 0, 678, DateTimeKind.Local).AddTicks(6595), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " 5G, 256 GB/12 GB,12MP+12MP+12MP/4MP", "https://www.hgspot.hr/image/catalog/slike/167318-878.jpg", false, false, 12000m, 10000m, "Samsung Galaxy Z Fold 3" },
                    { 4, 2, new DateTime(2022, 8, 14, 13, 15, 0, 678, DateTimeKind.Local).AddTicks(6605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5G,128GB, Midnight", "https://www.hgspot.hr/image/catalog/slike/162633-878.jpg ", false, false, 6500m, 4500m, "Apple iPhone 13 Mini" },
                    { 5, 3, new DateTime(2022, 8, 14, 13, 15, 0, 678, DateTimeKind.Local).AddTicks(6611), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "DRIVERS 40 mm,DRIVER TYPE Dynamic,DRIVER IMPEDANCE 32 OHM,DRIVER SENSITIVITY 97 dB SPL,FREQUENCY RESPONSE 20Hz-20kHz ", "https://www.hgspot.hr/image/catalog/slike/126934-878.jpg ", false, false, 1500m, 1200m, "Slušalice + mikrofon MARSHALL Major III " }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

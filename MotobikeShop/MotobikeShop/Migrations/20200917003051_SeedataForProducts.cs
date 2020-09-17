using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MotobikeShop.Migrations
{
    public partial class SeedataForProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91",
                column: "ConcurrencyStamp",
                value: "6802cdca-bebc-4ac1-b718-063a12ff80e4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "f80dfbf1-2c6b-494c-b957-eb10dca0d60f", "AQAAAAEAACcQAAAAEBgdakbBZosqwugs8rvM6fKJnIv5lPR2zfiRpFA8NH8/lZgNWPBIw7l0hNjpESDgqA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "178a2622-bdf0-451d-83ee-8d69ed407062", "AQAAAAEAACcQAAAAECf7R2Sv2L+dPrxPGrpTlBaGLv9OXLSLQcEr3hw/yLQu6/k9RPhGD5tAB3qGjIGMrg==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "ImagePath", "Name", "PricePerUnit" },
                values: new object[] { new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "Honda-XR150.jpg", "Honda XR150", 40000000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ImagePath", "Name", "PricePerUnit" },
                values: new object[] { new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "Honda-CRF150.jpg", "Honda CRF150", 60000000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreateAt", "ImagePath", "Name", "PricePerUnit" },
                values: new object[] { 2, new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "WR150.jpg", "WR 150", 42000000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreateAt", "ImagePath", "Name", "PricePerUnit" },
                values: new object[] { 3, new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "DR150.jpg", "DR 150", 45000000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreateAt", "ImagePath", "Name", "PricePerUnit" },
                values: new object[] { 5, new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "Klx110.jpg", "KLX 110", 50000000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreateAt", "ImagePath", "Name" },
                values: new object[] { 5, new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "klx125.jpg", "KLX 125" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91",
                column: "ConcurrencyStamp",
                value: "8f63ac1e-e012-4efc-912d-cbe0e852a2e4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "1938d925-8b92-4190-8882-00d8f865a632", "AQAAAAEAACcQAAAAEK1/7hGtl+g4jc2f+T0vDcRbeBg/XZ+o60QRanjt4Z2VlYgwXqT1bPOpYMCyOzKYIQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "1328f18f-56e0-483a-97b3-d51a4e9f1eca", "AQAAAAEAACcQAAAAEPPO/4RfIEmt0KqBzXRM72dQFi/T0+VEm6hLCgpr22+VNFx43f8V0EifMvK9V3Q+2g==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "ImagePath", "Name", "PricePerUnit" },
                values: new object[] { new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "default_product_image.png", "Iphone 5", 5000000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ImagePath", "Name", "PricePerUnit" },
                values: new object[] { new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "default_product_image.png", "Iphone 6", 6000000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreateAt", "ImagePath", "Name", "PricePerUnit" },
                values: new object[] { 1, new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "default_product_image.png", "Iphone 7", 7000000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreateAt", "ImagePath", "Name", "PricePerUnit" },
                values: new object[] { 2, new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "default_product_image.png", "Galaxy 3", 3000000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreateAt", "ImagePath", "Name", "PricePerUnit" },
                values: new object[] { 2, new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "default_product_image.png", "Galaxy 4", 4000000.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreateAt", "ImagePath", "Name" },
                values: new object[] { 3, new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "default_product_image.png", "BPhone 10" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateAt", "CreateBy", "ImagePath", "Name", "PricePerUnit", "Status" },
                values: new object[] { 7, 3, new DateTime(2020, 9, 16, 0, 0, 0, 0, DateTimeKind.Local), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "default_product_image.png", "BPhone 11", 11000000.0, 1 });
        }
    }
}

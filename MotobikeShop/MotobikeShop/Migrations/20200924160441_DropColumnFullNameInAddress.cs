using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MotobikeShop.Migrations
{
    public partial class DropColumnFullNameInAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Addresses");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "AFC2B52F-5EFC-4A24-B6CC-AB8ABF81857E",
                column: "ConcurrencyStamp",
                value: "58ddc08d-c2a7-49ba-9a07-bd83e209217b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                column: "ConcurrencyStamp",
                value: "ee30da90-49ea-480f-bfe0-365add6071fa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "b9eca118-d374-4f70-ba7c-33b0b1b3ec27", "AQAAAAEAACcQAAAAEAl/4LOXjRUsV3ujGDKT1OW5UDGIDftczeC8DlH85cqNsL7+s98gyZdrGjpDiw9Tvg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "058de195-b6ee-4e6a-8b7e-c342119e6dd5", "AQAAAAEAACcQAAAAEFBbYqDVhvFgmRq09NH4osFGhvubR6+sdaRCfCu3wQZPeMb53OoZrpZbQlqttgFxPQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Logo", "Status" },
                values: new object[] { "Hãng Xe Honda xuất xứ ở nhật, tiết kiệm nhiên liệu", "Honda-Logo-Wallpapers-Full-Download.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Logo", "Status" },
                values: new object[] { "Thiết kế phong cách thể thao", "YamahaBackground.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Logo", "Status" },
                values: new object[] { "Dành cho người thích tốc độ", "SuzukiLogo.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Logo", "Status" },
                values: new object[] { "Dành cho người chơi cào cào chuyên nghiệp", "ktmLogo.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Logo", "Status" },
                values: new object[] { "Vượt địa hình hiểm trở", "KawasakiLogo.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Logo", "Status" },
                values: new object[] { "Hãng xe cào cào nổi tiếng trong nhiều năm qua", "BetaLogo.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImagePath", "Status" },
                values: new object[] { "Honda-XR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImagePath", "Status" },
                values: new object[] { "Honda-CRF150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImagePath", "Status" },
                values: new object[] { "WR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImagePath", "Status" },
                values: new object[] { "DR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImagePath", "Status" },
                values: new object[] { "Klx110.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImagePath", "Status" },
                values: new object[] { "klx125.jpg", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "AFC2B52F-5EFC-4A24-B6CC-AB8ABF81857E",
                column: "ConcurrencyStamp",
                value: "0d1e1421-0b68-4a66-a3e6-5c05d9aeb276");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                column: "ConcurrencyStamp",
                value: "bcced26c-5452-44fb-9452-4fdc9b9b2fcf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "70a20872-adfd-4648-8c00-dc2cfe8b89e8", "AQAAAAEAACcQAAAAEBTzXarmCK0movrR2gDRbtFgnRW2UgZZcyVUgDtoxxIE5z+D4IvXOTrMy5JJX0ADcw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "761f6520-7da4-4649-9a16-d6d6ab4d01c4", "AQAAAAEAACcQAAAAEFq63p0z0uXwDo7nvjuRFswEcAT7rUdcOZRfv2/deAK5kvIMbsGGfR2CN0wG92f7OQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Logo", "Status" },
                values: new object[] { "Hãng Xe Honda xuất xứ ở nhật, tiết kiệm nhiên liệu", "Honda-Logo-Wallpapers-Full-Download.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Logo", "Status" },
                values: new object[] { "Thiết kế phong cách thể thao", "YamahaBackground.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Logo", "Status" },
                values: new object[] { "Dành cho người thích tốc độ", "SuzukiLogo.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Logo", "Status" },
                values: new object[] { "Dành cho người chơi cào cào chuyên nghiệp", "ktmLogo.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Logo", "Status" },
                values: new object[] { "Vượt địa hình hiểm trở", "KawasakiLogo.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Logo", "Status" },
                values: new object[] { "Hãng xe cào cào nổi tiếng trong nhiều năm qua", "BetaLogo.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImagePath", "Status" },
                values: new object[] { "Honda-XR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImagePath", "Status" },
                values: new object[] { "Honda-CRF150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImagePath", "Status" },
                values: new object[] { "WR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImagePath", "Status" },
                values: new object[] { "DR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImagePath", "Status" },
                values: new object[] { "Klx110.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImagePath", "Status" },
                values: new object[] { "klx125.jpg", 1 });
        }
    }
}

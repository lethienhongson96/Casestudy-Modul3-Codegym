﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace MotobikeShop.Migrations
{
    public partial class CreateInfoCustomerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InfoCustomers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    PhoneNum = table.Column<string>(maxLength: 20, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    AddressId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoCustomers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91",
                column: "ConcurrencyStamp",
                value: "3bf26d14-29ab-4703-a764-8a59ae3a0648");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "02cb1435-bd8e-4007-9043-35a476c78258", "AQAAAAEAACcQAAAAEJK02a8dQHo0tXw4GE8ldfdAmGG8sLiJClHb5c/yyetF27RZfF63IDaxD9ZuSTFKzg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "5373f6c2-6dbb-4ec7-b62b-09bcc70b6327", "AQAAAAEAACcQAAAAEGoHjhskRsUHrDb+aFftO2jlpioK/Z2ZVTPYkw++buTvJD2U3zxVqgU7myt4ERS95w==" });

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
            migrationBuilder.DropTable(
                name: "InfoCustomers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91",
                column: "ConcurrencyStamp",
                value: "062b4746-9b22-42e6-8530-d2d7a55e5303");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "391decd7-806a-4e56-95a0-19e92c7aa710", "AQAAAAEAACcQAAAAEJMhN5bhcbcbnFsMDAVm88HNgh445448DIlW7a8JSkX1fvAClQOPUeFN+5NJzK7TFQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "4b077b1c-7ed3-4fb5-9407-a6a1dc055a1e", "AQAAAAEAACcQAAAAEHRgmRQp0kgDcSU4+iEVVrem0sEkq/gOlg7awQYeje4VoDF6GBU9AQfGMfiQk58XdQ==" });

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

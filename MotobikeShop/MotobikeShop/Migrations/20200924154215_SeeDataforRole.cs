using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MotobikeShop.Migrations
{
    public partial class SeeDataforRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShipperDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateAt",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "AFC2B52F-5EFC-4A24-B6CC-AB8ABF81857E", "0d1e1421-0b68-4a66-a3e6-5c05d9aeb276", "Admin", "Admin" },
                    { "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "bcced26c-5452-44fb-9452-4fdc9b9b2fcf", "Customer", "Customer" }
                });

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
                columns: new[] { "CreateAt", "Description", "Logo", "Status" },
                values: new object[] { new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Hãng Xe Honda xuất xứ ở nhật, tiết kiệm nhiên liệu", "Honda-Logo-Wallpapers-Full-Download.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "Description", "Logo", "Status" },
                values: new object[] { new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Thiết kế phong cách thể thao", "YamahaBackground.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "Description", "Logo", "Status" },
                values: new object[] { new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Dành cho người thích tốc độ", "SuzukiLogo.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "Description", "Logo", "Status" },
                values: new object[] { new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Dành cho người chơi cào cào chuyên nghiệp", "ktmLogo.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "Description", "Logo", "Status" },
                values: new object[] { new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Vượt địa hình hiểm trở", "KawasakiLogo.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "Description", "Logo", "Status" },
                values: new object[] { new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Hãng xe cào cào nổi tiếng trong nhiều năm qua", "BetaLogo.jpg", 1 });

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
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Honda-XR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Honda-CRF150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "WR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "DR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "Klx110.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local), "klx125.jpg", 1 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "AFC2B52F-5EFC-4A24-B6CC-AB8ABF81857E" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "FC876771-8301-4765-B037-859AA899D708", "CE6654BD-705E-4D25-8C90-71E2654ADAE8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "AFC2B52F-5EFC-4A24-B6CC-AB8ABF81857E" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "FC876771-8301-4765-B037-859AA899D708", "CE6654BD-705E-4D25-8C90-71E2654ADAE8" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "AFC2B52F-5EFC-4A24-B6CC-AB8ABF81857E");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShipperDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 9, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91", "706f9fa1-5b6c-4075-8525-b548e689a49a", "Admin", "Admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "a6f42b76-5104-4b6c-ab25-55ec5e62540e", "AQAAAAEAACcQAAAAEFotgKTg4gX/+b83/mznNAZV2d5YG615msvif3kOjUOd8E2qQN0HnCIiQJgrunB9wA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "5d44dbb6-e2c2-457d-ace0-c5a5040b9053", "AQAAAAEAACcQAAAAEDV4igG722T0/RRsxWNVtlrAU2YRbJsom7pG2g6dUdTi0o2u5MQxyCgnTlXXgp7U1w==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Description", "Logo", "Status" },
                values: new object[] { new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Hãng Xe Honda xuất xứ ở nhật, tiết kiệm nhiên liệu", "Honda-Logo-Wallpapers-Full-Download.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "Description", "Logo", "Status" },
                values: new object[] { new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Thiết kế phong cách thể thao", "YamahaBackground.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "Description", "Logo", "Status" },
                values: new object[] { new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Dành cho người thích tốc độ", "SuzukiLogo.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "Description", "Logo", "Status" },
                values: new object[] { new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Dành cho người chơi cào cào chuyên nghiệp", "ktmLogo.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "Description", "Logo", "Status" },
                values: new object[] { new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Vượt địa hình hiểm trở", "KawasakiLogo.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "Description", "Logo", "Status" },
                values: new object[] { new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Hãng xe cào cào nổi tiếng trong nhiều năm qua", "BetaLogo.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Honda-XR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Honda-CRF150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "WR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "DR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Klx110.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "klx125.jpg", 1 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MotobikeShop.Migrations
{
    public partial class DropColumnAddressIdInInfoCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "InfoCustomers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShipperDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateAt",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "InfoCustomers",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91",
                column: "ConcurrencyStamp",
                value: "706f9fa1-5b6c-4075-8525-b548e689a49a");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "InfoCustomers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ShipperDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateAt",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2020, 9, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "InfoCustomers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91",
                column: "ConcurrencyStamp",
                value: "8b29ba13-8cc1-488c-a5cd-96ae4b5bd843");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "349a2bfa-5bed-4ade-b536-a75e255c920f", "AQAAAAEAACcQAAAAEGYZcYtWq8sFDewBAJpSo38ML37s42AQZNtlvakTSCrCO73v/x+nAh4INgpx2Dtyeg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "eccbbd10-c16d-4380-b5b1-188b2bc8c57e", "AQAAAAEAACcQAAAAECfRBcdljJjkUj5ed+P0QIVSGexmpZ1o+QrSqQviUD4M4uu4aUnOq98T8k70UNdMbA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Description", "Logo", "Status" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Hãng Xe Honda xuất xứ ở nhật, tiết kiệm nhiên liệu", "Honda-Logo-Wallpapers-Full-Download.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "Description", "Logo", "Status" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Thiết kế phong cách thể thao", "YamahaBackground.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "Description", "Logo", "Status" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Dành cho người thích tốc độ", "SuzukiLogo.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "Description", "Logo", "Status" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Dành cho người chơi cào cào chuyên nghiệp", "ktmLogo.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "Description", "Logo", "Status" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Vượt địa hình hiểm trở", "KawasakiLogo.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "Description", "Logo", "Status" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Hãng xe cào cào nổi tiếng trong nhiều năm qua", "BetaLogo.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Honda-XR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Honda-CRF150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "WR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "DR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "Klx110.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local), "klx125.jpg", 1 });
        }
    }
}

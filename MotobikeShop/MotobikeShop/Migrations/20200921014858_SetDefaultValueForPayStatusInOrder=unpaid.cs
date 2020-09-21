using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MotobikeShop.Migrations
{
    public partial class SetDefaultValueForPayStatusInOrderunpaid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PayStatus",
                table: "Orders",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91",
                column: "ConcurrencyStamp",
                value: "92f935ff-4314-44bc-923e-64583973bb88");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "84977446-8d3d-47be-a718-70091197bf31", "AQAAAAEAACcQAAAAED8rNxEyTjYM1KvSAARFe5pI327nvzVwLeSp60w7eJcFb8TuxW64M4JdwncfAdH0Aw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "14e9d434-50da-4006-957d-bcb41addf0d1", "AQAAAAEAACcQAAAAEDDFc8ihWSon/0U+AyO6ZUXi1KLV2A4rc+qBfAOOTXR8xfitvSqEKVvIL6faDJEsOw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Status" },
                values: new object[] { new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "Status" },
                values: new object[] { new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "Status" },
                values: new object[] { new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "Status" },
                values: new object[] { new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Honda-XR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Honda-CRF150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "WR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "DR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "Klx110.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 21, 0, 0, 0, 0, DateTimeKind.Local), "klx125.jpg", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PayStatus",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldDefaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91",
                column: "ConcurrencyStamp",
                value: "1427a376-913c-4e71-8248-72c4ec7725af");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "9d205463-9d3b-41e0-bfb7-61aa2c8430b1", "AQAAAAEAACcQAAAAEAEj3GVrwD+bCSCudTn6Wwb8WNBKpIS3/x2nEDwW2id33hZbjAc4wsZz+4XSm8gUfA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "88244511-4d1b-41c1-9178-70799e6c9c6e", "AQAAAAEAACcQAAAAEN8b1F8DRS6eQ3whEKxo9IswwnXgABW2vHdiXnIMO3kpLLthhTfcUKSosy93nTL7hA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Status" },
                values: new object[] { new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "Status" },
                values: new object[] { new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "Status" },
                values: new object[] { new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "Status" },
                values: new object[] { new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Honda-XR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Honda-CRF150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "WR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "DR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "Klx110.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "klx125.jpg", 1 });
        }
    }
}

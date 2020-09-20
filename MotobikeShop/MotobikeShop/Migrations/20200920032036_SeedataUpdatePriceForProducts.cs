using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MotobikeShop.Migrations
{
    public partial class SeedataUpdatePriceForProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91",
                column: "ConcurrencyStamp",
                value: "32d01ebb-75ea-4233-a233-061a2b83c760");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "b478e468-2a70-408f-86d6-8d56f404413c", "AQAAAAEAACcQAAAAECJ1iUdZVXSyaViFmJaTzTq9RDttqAoKSM3TUmQZ30vf+xQ6mkd1T+5qyC9r9xWSWw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "8d343d68-38aa-4d6d-8fba-438fe4e5b6de", "AQAAAAEAACcQAAAAEI1d/gmiphkQsGGR2eJmCQwjk2GImHvQmn+p7cMJi67T+kHC3X5kBvaIqq+lQTBeeA==" });

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
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, 1 },
                column: "UnitPrice",
                value: 40000000.0);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, 2 },
                column: "UnitPrice",
                value: 120000000.0);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 2, 3 },
                column: "UnitPrice",
                value: 42000000.0);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 2, 4 },
                column: "UnitPrice",
                value: 135000000.0);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 3, 5 },
                column: "UnitPrice",
                value: 50000000.0);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 3, 6 },
                column: "UnitPrice",
                value: 70000000.0);

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
                columns: new[] { "CreateAt", "ImagePath", "PricePerUnit", "Status" },
                values: new object[] { new DateTime(2020, 9, 20, 0, 0, 0, 0, DateTimeKind.Local), "klx125.jpg", 35000000.0, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91",
                column: "ConcurrencyStamp",
                value: "b39ee200-d9d1-403b-8ed1-2a1bd9848be6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "d0ccb399-e3d3-4478-acd7-b94572d521cb", "AQAAAAEAACcQAAAAEANtMD2kohQqCnAWduCYHkmbqCALRn/X90Y3OkoBIT071YfPWflpZSw2N9dNeFjc4w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "e85a56d6-c6cd-46e1-9103-b7ec76f0ad5e", "AQAAAAEAACcQAAAAEPdkCmwqUjP2aNgPfcnPepB0EsfiEDR5Cy+dofgNGvqeoCwZtIwHW4QSN02/I1owEQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Status" },
                values: new object[] { new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "Status" },
                values: new object[] { new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "Status" },
                values: new object[] { new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "Status" },
                values: new object[] { new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), 1 });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, 1 },
                column: "UnitPrice",
                value: 5000000.0);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, 2 },
                column: "UnitPrice",
                value: 12000000.0);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 2, 3 },
                column: "UnitPrice",
                value: 7000000.0);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 2, 4 },
                column: "UnitPrice",
                value: 9000000.0);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 3, 5 },
                column: "UnitPrice",
                value: 4000000.0);

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 3, 6 },
                column: "UnitPrice",
                value: 20000000.0);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Honda-XR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Honda-CRF150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "WR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "DR150.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "ImagePath", "Status" },
                values: new object[] { new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "Klx110.jpg", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "ImagePath", "PricePerUnit", "Status" },
                values: new object[] { new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "klx125.jpg", 10000000.0, 1 });
        }
    }
}

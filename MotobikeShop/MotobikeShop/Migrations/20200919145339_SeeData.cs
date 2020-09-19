using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MotobikeShop.Migrations
{
    public partial class SeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "ApplicationUserId", "DistrictId", "FullName", "HouseNum", "ProvinceId", "WardId" },
                values: new object[,]
                {
                    { 1, null, 194, null, "28 Nguyễn Tri Phương", 15, 2724 },
                    { 2, null, 194, null, "28 Nguyễn Tri Phương", 15, 2724 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91", "4f540798-ee7e-4c6d-84be-1dc8d054aff2", "Admin", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "AddressId", "Avatar", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "CE6654BD-705E-4D25-8C90-71E2654ADAE8", 0, 1, "DefaultAvatar.png", "18295147-a5a2-41b1-9b62-b936151f0241", "lethienhongson96@gmail.com", true, "Hồng Sơn", false, null, "lethienhongson96@gmail.com", "lethienhongson96@gmail.com", "AQAAAAEAACcQAAAAEB9SGovb5JCzyLPT7Fb5FrHST2fbbKc1UARTWdCATO/epiwKtowCYUC7jxqSmoQR0Q==", "0982102073", false, "", false, "lethienhongson96@gmail.com" },
                    { "FC876771-8301-4765-B037-859AA899D708", 0, 2, "DefaultAvatar.png", "b31de388-fe6c-4a2b-8862-d1d662de991b", "Customer@gmail.com", true, "Nguyễn Văn Vui", false, null, "Customer@gmail.com", "Customer@gmail.com", "AQAAAAEAACcQAAAAEH0XSiV91/X/9VtdNl/KdL2+413E6UwApRduV+op8IaT7RWWwriijcazmtNSQAyhCA==", "0984910724", false, "", false, "Customer@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "CreateBy", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "HonDa", 1 },
                    { 2, new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "Yamaha", 1 },
                    { 3, new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "Suzuki", 1 },
                    { 4, new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "Ktm", 1 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreateAt", "CreateBy", "PayStatus", "ShipperDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "FC876771-8301-4765-B037-859AA899D708", 0, new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "FC876771-8301-4765-B037-859AA899D708", 0, new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "FC876771-8301-4765-B037-859AA899D708", 0, new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreateAt", "CreateBy", "ImagePath", "Name", "PricePerUnit", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "Honda-XR150.jpg", "Honda XR150", 40000000.0, 1 },
                    { 2, 1, new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "Honda-CRF150.jpg", "Honda CRF150", 60000000.0, 1 },
                    { 3, 2, new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "WR150.jpg", "WR 150", 42000000.0, 1 },
                    { 4, 3, new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "DR150.jpg", "DR 150", 45000000.0, 1 },
                    { 5, 4, new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "Klx110.jpg", "KLX 110", 50000000.0, 1 },
                    { 6, 4, new DateTime(2020, 9, 19, 0, 0, 0, 0, DateTimeKind.Local), "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "klx125.jpg", "KLX 125", 10000000.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "PayStatus", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 0, 1, 5000000.0 },
                    { 1, 2, 0, 2, 12000000.0 },
                    { 2, 3, 0, 1, 7000000.0 },
                    { 2, 4, 0, 3, 9000000.0 },
                    { 3, 5, 0, 1, 4000000.0 },
                    { 3, 6, 0, 2, 20000000.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "CE6654BD-705E-4D25-8C90-71E2654ADAE8", "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91" });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91");

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

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
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708");

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

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8");
        }
    }
}

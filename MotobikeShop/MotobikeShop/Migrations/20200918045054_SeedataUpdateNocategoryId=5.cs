using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MotobikeShop.Migrations
{
    public partial class SeedataUpdateNocategoryId5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91",
                column: "ConcurrencyStamp",
                value: "2e865de8-d65b-4838-a826-9ff2fe9b6cee");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "337b57e6-de91-4cd9-9f61-c19802fe14b9", "AQAAAAEAACcQAAAAEDWR00INSY6PqCaKdgTpEHDwE12W+YKcS3bJJPteqASUv1dV5xABrVIga01tXl6jpg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "b8505101-d98e-4d39-96be-06035a4dd33f", "AQAAAAEAACcQAAAAECKrOJ2tHLV+vmmK9UT0h1EtPgkzt22B03jnISFEPnGTvRQ9ShXrI82gzkrF5L2bDQ==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "Name" },
                values: new object[] { new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "Ktm" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "Name" },
                values: new object[] { new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "No Category" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "ShipperDate" },
                values: new object[] { new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "ImagePath" },
                values: new object[] { new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "Honda-XR150.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ImagePath" },
                values: new object[] { new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "Honda-CRF150.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "ImagePath" },
                values: new object[] { new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "WR150.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "ImagePath" },
                values: new object[] { new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "DR150.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreateAt", "ImagePath" },
                values: new object[] { 4, new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "Klx110.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreateAt", "ImagePath" },
                values: new object[] { 4, new DateTime(2020, 9, 18, 0, 0, 0, 0, DateTimeKind.Local), "klx125.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreateAt", "Name" },
                values: new object[] { new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "No Category" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "Name" },
                values: new object[] { new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "Ktm" });

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
                columns: new[] { "CreateAt", "ImagePath" },
                values: new object[] { new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "Honda-XR150.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "ImagePath" },
                values: new object[] { new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "Honda-CRF150.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "ImagePath" },
                values: new object[] { new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "WR150.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "ImagePath" },
                values: new object[] { new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "DR150.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreateAt", "ImagePath" },
                values: new object[] { 5, new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "Klx110.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreateAt", "ImagePath" },
                values: new object[] { 5, new DateTime(2020, 9, 17, 0, 0, 0, 0, DateTimeKind.Local), "klx125.jpg" });
        }
    }
}

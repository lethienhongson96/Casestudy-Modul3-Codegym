using Microsoft.EntityFrameworkCore.Migrations;

namespace MotobikeShop.Migrations
{
    public partial class RelationShipForOrderAndInfoCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InfoCustomerId",
                table: "Orders",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91",
                column: "ConcurrencyStamp",
                value: "f3007e64-f549-40d3-9d64-14b60e278952");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "9a0b2c70-25b3-42b5-a7ab-f7270d3dbe61", "AQAAAAEAACcQAAAAEADlQ/BDHh0+dLivyff2W1GSesPy4Jli2gH1g7W7RtRF+YVE7YYry7mhbkgfn3YiJw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "FC876771-8301-4765-B037-859AA899D708",
                columns: new[] { "Avatar", "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "DefaultAvatar.png", "de4f3248-57ff-4885-9dc0-97159e31a62f", "AQAAAAEAACcQAAAAEBMIoAVq61vdD5qpROviUbTqeQlwep8XOsaQpWBNO7YbHiZV+KOuCQQsdbgGSguVzA==" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_InfoCustomerId",
                table: "Orders",
                column: "InfoCustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_InfoCustomers_InfoCustomerId",
                table: "Orders",
                column: "InfoCustomerId",
                principalTable: "InfoCustomers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_InfoCustomers_InfoCustomerId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_InfoCustomerId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "InfoCustomerId",
                table: "Orders");

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
    }
}

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MotobikeShop.Models;
using MotobikeShop.Models.Entities;
using System;

namespace MotobikeShop.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            const string ADMIN_ID = "CE6654BD-705E-4D25-8C90-71E2654ADAE8";
            const string CustomerId = "FC876771-8301-4765-B037-859AA899D708";

            const string CustomerRole_ID = "CE6654BD-705E-4D25-8C90-71E2654ADAE8";
            const string AdminRole_ID = "AFC2B52F-5EFC-4A24-B6CC-AB8ABF81857E";

            modelBuilder.Entity<Address>().HasData(new Address
            {
                Id = 1,
                ProvinceId = 15,
                DistrictId = 194,
                WardId = 2724,
                HouseNum = "28 Nguyễn Tri Phương",
                ApplicationUserId = ADMIN_ID
            });


            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = AdminRole_ID,
                Name = "Admin",
                NormalizedName = "Admin"
            },
            new IdentityRole
            {
                Id = CustomerRole_ID,
                Name = "Customer",
                NormalizedName = "Customer"
            });

            var hasher = new PasswordHasher<ApplicationUser>();
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = ADMIN_ID,
                UserName = "lethienhongson96@gmail.com",
                NormalizedUserName = "lethienhongson96@gmail.com",
                Email = "lethienhongson96@gmail.com",
                NormalizedEmail = "lethienhongson96@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Asdf123!"),
                SecurityStamp = string.Empty,
                FullName = "Hồng Sơn",
                AddressId = 1,
                Avatar = "DefaultAvatar.png",
                PhoneNumber = "0982102073"
            });


            #region Seedata for Category
            modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1,
                Name = "HonDa",
                Status = Enums.Status.Active,
                CreateAt = DateTime.Today,
                CreateBy = ADMIN_ID,
                Logo = "Honda-Logo-Wallpapers-Full-Download.jpg",
                Description="Hãng Xe Honda xuất xứ ở nhật, tiết kiệm nhiên liệu"
            },
            new Category
            {
                Id = 2,
                Name = "Yamaha",
                Status = Enums.Status.Active,
                CreateAt = DateTime.Today,
                CreateBy = ADMIN_ID,
                Logo = "YamahaBackground.jpg",
                Description = "Thiết kế phong cách thể thao"
            },
            new Category
            {
                Id = 3,
                Name = "Suzuki",
                Status = Enums.Status.Active,
                CreateAt = DateTime.Today,
                CreateBy = ADMIN_ID,
                Logo = "SuzukiLogo.jpg",
                Description = "Dành cho người thích tốc độ"
            },
            new Category
            {
                Id = 4,
                Name = "Ktm",
                Status = Enums.Status.Active,
                CreateAt = DateTime.Today,
                CreateBy = ADMIN_ID,
                Logo = "ktmLogo.jpg",
                Description = "Dành cho người chơi cào cào chuyên nghiệp"
            }
            ,
            new Category
            {
                Id = 5,
                Name = "Kawasaki",
                Status = Enums.Status.Active,
                CreateAt = DateTime.Today,
                CreateBy = ADMIN_ID,
                Logo = "KawasakiLogo.jpg",
                Description = "Vượt địa hình hiểm trở"
            }
            ,
            new Category
            {
                Id = 6,
                Name = "Beta",
                Status = Enums.Status.Active,
                CreateAt = DateTime.Today,
                CreateBy = ADMIN_ID,
                Logo = "BetaLogo.jpg",
                Description = "Hãng xe cào cào nổi tiếng trong nhiều năm qua"
            }
            );
            #endregion

         

            modelBuilder.Entity<Address>().HasData(new Address
            {
                Id = 2,
                ProvinceId = 15,
                DistrictId = 194,
                WardId = 2724,
                HouseNum = "28 Nguyễn Tri Phương",
                ApplicationUserId = CustomerId
            });

            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = CustomerId,
                UserName = "Customer@gmail.com",
                NormalizedUserName = "Customer@gmail.com",
                Email = "Customer@gmail.com",
                NormalizedEmail = "Customer@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Asdf123!"),
                SecurityStamp = string.Empty,
                FullName = "Nguyễn Văn Vui",
                AddressId = 2,
                Avatar = "DefaultAvatar.png",
                PhoneNumber = "0984910724"
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string> { RoleId = AdminRole_ID, UserId = ADMIN_ID },
            new IdentityUserRole<string> { RoleId = CustomerRole_ID, UserId = CustomerId }
            );
            #region Create Product
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Honda XR150",
                    PricePerUnit = 40000000,
                    CreateAt = DateTime.Today,
                    ImagePath = "Honda-XR150.jpg",
                    Status = Enums.Status.Active,
                    CategoryId = 1,
                    CreateBy = ADMIN_ID
                },
                new Product
                {
                    Id = 2,
                    Name = "Honda CRF150",
                    PricePerUnit = 60000000,
                    CreateAt = DateTime.Today,
                    ImagePath = "Honda-CRF150.jpg",
                    Status = Enums.Status.Active,
                    CategoryId = 1,
                    CreateBy = ADMIN_ID
                },
                new Product
                {
                    Id = 3,
                    Name = "WR 150",
                    PricePerUnit = 42000000,
                    CreateAt = DateTime.Today,
                    ImagePath = "WR150.jpg",
                    Status = Enums.Status.Active,
                    CategoryId = 2,
                    CreateBy = ADMIN_ID
                },
                new Product
                {
                    Id = 4,
                    Name = "DR 150",
                    PricePerUnit = 45000000,
                    CreateAt = DateTime.Today,
                    ImagePath = "DR150.jpg",
                    Status = Enums.Status.Active,
                    CategoryId = 3,
                    CreateBy = ADMIN_ID
                },
                new Product
                {
                    Id = 5,
                    Name = "KLX 110",
                    PricePerUnit = 50000000,
                    CreateAt = DateTime.Today,
                    ImagePath = "Klx110.jpg",
                    Status = Enums.Status.Active,
                    CategoryId = 4,
                    CreateBy = ADMIN_ID
                },
                new Product
                {
                    Id = 6,
                    Name = "KLX 125",
                    PricePerUnit = 35000000,
                    CreateAt = DateTime.Today,
                    ImagePath = "klx125.jpg",
                    Status = Enums.Status.Active,
                    CategoryId = 4,
                    CreateBy = ADMIN_ID
                });
            #endregion


            #region Create Order and OrderDetail
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    PayStatus = Enums.PayStatus.unpaid,
                    CreateAt = DateTime.Today,
                    ShipperDate = DateTime.Today,
                    CreateBy = CustomerId
                },
                new Order
                {
                    Id = 2,
                    PayStatus = Enums.PayStatus.unpaid,
                    CreateAt = DateTime.Today,
                    ShipperDate = DateTime.Today,
                    CreateBy = CustomerId
                },
                new Order
                {
                    Id = 3,
                    PayStatus = Enums.PayStatus.unpaid,
                    CreateAt = DateTime.Today,
                    ShipperDate = DateTime.Today,
                    CreateBy = CustomerId
                });
            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail { OrderId = 1, ProductId = 1, Quantity = 1, UnitPrice = 40000000, PayStatus = Enums.PayStatus.unpaid },
                new OrderDetail { OrderId = 1, ProductId = 2, Quantity = 2, UnitPrice = 120000000, PayStatus = Enums.PayStatus.unpaid },
                new OrderDetail { OrderId = 2, ProductId = 3, Quantity = 1, UnitPrice = 42000000, PayStatus = Enums.PayStatus.unpaid },
                new OrderDetail { OrderId = 2, ProductId = 4, Quantity = 3, UnitPrice = 135000000, PayStatus = Enums.PayStatus.unpaid },
                new OrderDetail { OrderId = 3, ProductId = 5, Quantity = 1, UnitPrice = 50000000, PayStatus = Enums.PayStatus.unpaid },
                new OrderDetail { OrderId = 3, ProductId = 6, Quantity = 2, UnitPrice = 70000000, PayStatus = Enums.PayStatus.unpaid }
                );
            #endregion

        }
    }
}

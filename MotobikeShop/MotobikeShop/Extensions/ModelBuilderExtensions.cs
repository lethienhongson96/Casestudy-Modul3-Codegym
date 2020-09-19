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
            // any guid, but nothing is against to use the same one
            const string ROLE_ID = "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91";

            modelBuilder.Entity<Address>().HasData(new Address
            {
                Id = 1,
                ProvinceId = 15,
                DistrictId = 194,
                WardId = 2724,
                HouseNum = "28 Nguyễn Tri Phương",
                ApplicationUserId= ADMIN_ID
            });

            
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = ROLE_ID,
                Name = "Admin",
                NormalizedName = "Admin"
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

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });

            modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "HonDa", Status = Enums.Status.Active, CreateAt = DateTime.Today, CreateBy = ADMIN_ID },
            new Category { Id = 2, Name = "Yamaha", Status = Enums.Status.Active, CreateAt = DateTime.Today, CreateBy = ADMIN_ID },
            new Category { Id = 3, Name = "Suzuki", Status = Enums.Status.Active, CreateAt = DateTime.Today, CreateBy = ADMIN_ID },
            new Category { Id = 4, Name = "Ktm", Status = Enums.Status.Active, CreateAt = DateTime.Today, CreateBy = ADMIN_ID }
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
                    PricePerUnit = 10000000,
                    CreateAt = DateTime.Today,
                    ImagePath = "klx125.jpg",
                    Status = Enums.Status.Active,
                    CategoryId = 4,
                    CreateBy = ADMIN_ID
                });
            #endregion

            var CustomerId = "FC876771-8301-4765-B037-859AA899D708";

            modelBuilder.Entity<Address>().HasData(new Address
            {
                Id = 2,
                ProvinceId = 15,
                DistrictId = 194,
                WardId = 2724,
                HouseNum = "28 Nguyễn Tri Phương",
                ApplicationUserId = CustomerId
            }); ;
            
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
                new OrderDetail { OrderId = 1, ProductId = 1, Quantity = 1, UnitPrice = 5000000, PayStatus = Enums.PayStatus.unpaid },
                new OrderDetail { OrderId = 1, ProductId = 2, Quantity = 2, UnitPrice = 12000000, PayStatus = Enums.PayStatus.unpaid },
                new OrderDetail { OrderId = 2, ProductId = 3, Quantity = 1, UnitPrice = 7000000, PayStatus = Enums.PayStatus.unpaid },
                new OrderDetail { OrderId = 2, ProductId = 4, Quantity = 3, UnitPrice = 9000000, PayStatus = Enums.PayStatus.unpaid },
                new OrderDetail { OrderId = 3, ProductId = 5, Quantity = 1, UnitPrice = 4000000, PayStatus = Enums.PayStatus.unpaid },
                new OrderDetail { OrderId = 3, ProductId = 6, Quantity = 2, UnitPrice = 20000000, PayStatus = Enums.PayStatus.unpaid }
                );
            #endregion
        }
    }
}

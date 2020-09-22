﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MotobikeShop.Models;

namespace MotobikeShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200922030050_SeedataDescriptionInCate")]
    partial class SeedataDescriptionInCate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91",
                            ConcurrencyStamp = "d528c58d-20c1-4b28-8069-34ba1f269776",
                            Name = "Admin",
                            NormalizedName = "Admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                            RoleId = "1A90DABB-1EE6-495A-940B-6E2E4EEC6B91"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MotobikeShop.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200)
                        .HasDefaultValue("DefaultAvatar.png");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                            AccessFailedCount = 0,
                            AddressId = 1,
                            Avatar = "DefaultAvatar.png",
                            ConcurrencyStamp = "0e2b8ff7-749c-4271-8f69-bf5d2536becd",
                            Email = "lethienhongson96@gmail.com",
                            EmailConfirmed = true,
                            FullName = "Hồng Sơn",
                            LockoutEnabled = false,
                            NormalizedEmail = "lethienhongson96@gmail.com",
                            NormalizedUserName = "lethienhongson96@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEFPvZ3Qr/n4F/+b2OBpJD6HSanmjRSefVNsCzjF9i1LCm/uv/QJsJWQIrv+C+zeoYA==",
                            PhoneNumber = "0982102073",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "lethienhongson96@gmail.com"
                        },
                        new
                        {
                            Id = "FC876771-8301-4765-B037-859AA899D708",
                            AccessFailedCount = 0,
                            AddressId = 2,
                            Avatar = "DefaultAvatar.png",
                            ConcurrencyStamp = "23c66b27-9d75-43f6-9d7c-7f5e0da5e6ab",
                            Email = "Customer@gmail.com",
                            EmailConfirmed = true,
                            FullName = "Nguyễn Văn Vui",
                            LockoutEnabled = false,
                            NormalizedEmail = "Customer@gmail.com",
                            NormalizedUserName = "Customer@gmail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAELYiq+FM64EBspNM6ZR/EVXpIhKC0uGIjyMIsqjril8rFjzqwAPZR4uqFtd6Pw538A==",
                            PhoneNumber = "0984910724",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Customer@gmail.com"
                        });
                });

            modelBuilder.Entity("MotobikeShop.Models.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseNum")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int");

                    b.Property<int>("WardId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId")
                        .IsUnique()
                        .HasFilter("[ApplicationUserId] IS NOT NULL");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApplicationUserId = "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                            DistrictId = 194,
                            HouseNum = "28 Nguyễn Tri Phương",
                            ProvinceId = 15,
                            WardId = 2724
                        },
                        new
                        {
                            Id = 2,
                            ApplicationUserId = "FC876771-8301-4765-B037-859AA899D708",
                            DistrictId = 194,
                            HouseNum = "28 Nguyễn Tri Phương",
                            ProvinceId = 15,
                            WardId = 2724
                        });
                });

            modelBuilder.Entity("MotobikeShop.Models.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250)
                        .HasDefaultValue("");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150)
                        .HasDefaultValue("LogoDefault.png");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.HasIndex("CreateBy");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            CreateBy = "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                            Description = "Hãng Xe Honda xuất xứ ở nhật, tiết kiệm nhiên liệu",
                            Logo = "Honda-Logo-Wallpapers-Full-Download.jpg",
                            Name = "HonDa",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            CreateBy = "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                            Description = "Thiết kế phong cách thể thao",
                            Logo = "YamahaBackground.jpg",
                            Name = "Yamaha",
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            CreateBy = "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                            Description = "Dành cho người thích tốc độ",
                            Logo = "LogoDefault.png",
                            Name = "Suzuki",
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            CreateAt = new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            CreateBy = "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                            Description = "Dành cho người chơi cào cào chuyên nghiệp",
                            Logo = "LogoDefault.png",
                            Name = "Ktm",
                            Status = 1
                        });
                });

            modelBuilder.Entity("MotobikeShop.Models.Entities.District", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnName("_name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Prefix")
                        .HasColumnName("_prefix")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int?>("ProvinceId")
                        .HasColumnName("_province_id")
                        .HasColumnType("int");

                    b.ToTable("district");
                });

            modelBuilder.Entity("MotobikeShop.Models.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PayStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<DateTime>("ShipperDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CreateBy");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            CreateBy = "FC876771-8301-4765-B037-859AA899D708",
                            PayStatus = 0,
                            ShipperDate = new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            CreateBy = "FC876771-8301-4765-B037-859AA899D708",
                            PayStatus = 0,
                            ShipperDate = new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            CreateBy = "FC876771-8301-4765-B037-859AA899D708",
                            PayStatus = 0,
                            ShipperDate = new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("MotobikeShop.Models.Entities.OrderDetail", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("Discount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("float")
                        .HasDefaultValue(0.0);

                    b.Property<int>("PayStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            ProductId = 1,
                            Discount = 0.0,
                            PayStatus = 0,
                            Quantity = 1,
                            UnitPrice = 40000000.0
                        },
                        new
                        {
                            OrderId = 1,
                            ProductId = 2,
                            Discount = 0.0,
                            PayStatus = 0,
                            Quantity = 2,
                            UnitPrice = 120000000.0
                        },
                        new
                        {
                            OrderId = 2,
                            ProductId = 3,
                            Discount = 0.0,
                            PayStatus = 0,
                            Quantity = 1,
                            UnitPrice = 42000000.0
                        },
                        new
                        {
                            OrderId = 2,
                            ProductId = 4,
                            Discount = 0.0,
                            PayStatus = 0,
                            Quantity = 3,
                            UnitPrice = 135000000.0
                        },
                        new
                        {
                            OrderId = 3,
                            ProductId = 5,
                            Discount = 0.0,
                            PayStatus = 0,
                            Quantity = 1,
                            UnitPrice = 50000000.0
                        },
                        new
                        {
                            OrderId = 3,
                            ProductId = 6,
                            Discount = 0.0,
                            PayStatus = 0,
                            Quantity = 2,
                            UnitPrice = 70000000.0
                        });
                });

            modelBuilder.Entity("MotobikeShop.Models.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImagePath")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150)
                        .HasDefaultValue("default_product_image.png");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<double>("PricePerUnit")
                        .HasColumnType("float");

                    b.Property<int>("SaleCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreateBy");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreateAt = new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            CreateBy = "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                            ImagePath = "Honda-XR150.jpg",
                            Name = "Honda XR150",
                            PricePerUnit = 40000000.0,
                            SaleCount = 0,
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreateAt = new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            CreateBy = "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                            ImagePath = "Honda-CRF150.jpg",
                            Name = "Honda CRF150",
                            PricePerUnit = 60000000.0,
                            SaleCount = 0,
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CreateAt = new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            CreateBy = "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                            ImagePath = "WR150.jpg",
                            Name = "WR 150",
                            PricePerUnit = 42000000.0,
                            SaleCount = 0,
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            CreateAt = new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            CreateBy = "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                            ImagePath = "DR150.jpg",
                            Name = "DR 150",
                            PricePerUnit = 45000000.0,
                            SaleCount = 0,
                            Status = 1
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 4,
                            CreateAt = new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            CreateBy = "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                            ImagePath = "Klx110.jpg",
                            Name = "KLX 110",
                            PricePerUnit = 50000000.0,
                            SaleCount = 0,
                            Status = 1
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 4,
                            CreateAt = new DateTime(2020, 9, 22, 0, 0, 0, 0, DateTimeKind.Local),
                            CreateBy = "CE6654BD-705E-4D25-8C90-71E2654ADAE8",
                            ImagePath = "klx125.jpg",
                            Name = "KLX 125",
                            PricePerUnit = 35000000.0,
                            SaleCount = 0,
                            Status = 1
                        });
                });

            modelBuilder.Entity("MotobikeShop.Models.Entities.Province", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnName("_code")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("Id")
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnName("_name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.ToTable("province");
                });

            modelBuilder.Entity("MotobikeShop.Models.Entities.Ward", b =>
                {
                    b.Property<int?>("DistrictId")
                        .HasColumnName("_district_id")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("_name")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Prefix")
                        .HasColumnName("_prefix")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int?>("ProvinceId")
                        .HasColumnName("_province_id")
                        .HasColumnType("int");

                    b.ToTable("ward");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MotobikeShop.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MotobikeShop.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MotobikeShop.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MotobikeShop.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MotobikeShop.Models.Entities.Address", b =>
                {
                    b.HasOne("MotobikeShop.Models.ApplicationUser", "ApplicationUser")
                        .WithOne("Address")
                        .HasForeignKey("MotobikeShop.Models.Entities.Address", "ApplicationUserId");
                });

            modelBuilder.Entity("MotobikeShop.Models.Entities.Category", b =>
                {
                    b.HasOne("MotobikeShop.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Categories")
                        .HasForeignKey("CreateBy");
                });

            modelBuilder.Entity("MotobikeShop.Models.Entities.Order", b =>
                {
                    b.HasOne("MotobikeShop.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Orders")
                        .HasForeignKey("CreateBy");
                });

            modelBuilder.Entity("MotobikeShop.Models.Entities.OrderDetail", b =>
                {
                    b.HasOne("MotobikeShop.Models.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MotobikeShop.Models.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MotobikeShop.Models.Entities.Product", b =>
                {
                    b.HasOne("MotobikeShop.Models.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MotobikeShop.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Products")
                        .HasForeignKey("CreateBy");
                });
#pragma warning restore 612, 618
        }
    }
}

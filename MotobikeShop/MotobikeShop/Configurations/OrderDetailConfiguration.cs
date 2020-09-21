﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MotobikeShop.Enums;
using MotobikeShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.Configurations
{
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {

            builder.HasKey(bc => new { bc.OrderId, bc.ProductId });

            builder.Property(el => el.Quantity).IsRequired();
            builder.Property(el => el.UnitPrice).IsRequired();

            builder.Property(el => el.Discount).HasDefaultValue(0);
            builder.Property(el => el.PayStatus).HasDefaultValue(PayStatus.unpaid);

            builder.HasOne(bc => bc.Order)
                .WithMany(b => b.OrderDetails)
                .HasForeignKey(bc => bc.OrderId);

            builder.HasOne(bc => bc.Product)
                .WithMany(c => c.OrderDetails)
                .HasForeignKey(bc => bc.ProductId);
        }
    }
}

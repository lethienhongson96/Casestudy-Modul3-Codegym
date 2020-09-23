using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MotobikeShop.Models.Entities;
using System;

namespace MotobikeShop.Configurations
{
    public class InfoCustomerConfiguration : IEntityTypeConfiguration<InfoCustomer>
    {
        public void Configure(EntityTypeBuilder<InfoCustomer> builder)
        {
            builder.Property(el => el.Email).HasMaxLength(100).IsRequired();
            builder.Property(el => el.Name).HasMaxLength(100).IsRequired();
            builder.Property(el => el.PhoneNum).HasMaxLength(20).IsRequired();
            builder.Property(el => el.Address).HasMaxLength(150).IsRequired();
        }
    }
}

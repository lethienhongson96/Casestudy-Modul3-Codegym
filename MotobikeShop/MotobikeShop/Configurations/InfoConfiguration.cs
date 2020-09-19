using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MotobikeShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.Configurations
{
    public class InfoConfiguration : IEntityTypeConfiguration<Info>
    {
        public void Configure(EntityTypeBuilder<Info> builder)
        {
            builder.Property(el => el.Email).HasMaxLength(100).IsRequired();
            builder.Property(el => el.FullName).HasMaxLength(100).IsRequired();
            builder.Property(el => el.PhoneNum).HasMaxLength(20).IsRequired();
        }
    }
}

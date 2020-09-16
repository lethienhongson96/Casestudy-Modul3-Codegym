using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MotobikeShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.Configurations
{
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.HasNoKey();

            builder.ToTable("district");

            builder.Property(e => e.Id).HasColumnName("id");

            builder.Property(e => e.Name)
                    .HasColumnName("_name")
                    .HasMaxLength(100);

            builder.Property(e => e.Prefix)
                    .HasColumnName("_prefix")
                    .HasMaxLength(20);

            builder.Property(e => e.ProvinceId).HasColumnName("_province_id");
        }
    }
}

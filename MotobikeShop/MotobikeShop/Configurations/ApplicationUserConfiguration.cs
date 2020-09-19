using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MotobikeShop.Models;
using MotobikeShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(el => el.FullName).IsRequired().HasMaxLength(100);

            builder.Property(el => el.Avatar)
                .IsRequired(false)
                .HasMaxLength(200)
                .HasDefaultValue("DefaultAvatar.png");

           /* builder.HasOne(s => s.Address)
                .WithOne(ad => ad.ApplicationUser)
                .HasForeignKey<Info>(ad => ad.ApplicationUserId);*/
        }
    }
}

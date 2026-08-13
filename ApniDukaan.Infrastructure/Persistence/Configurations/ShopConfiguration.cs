using ApniDukaan.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApniDukaan.Infrastructure.Persistence.Configurations
{
    public class ShopConfiguration : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.HasKey(s => s.ShopId);
            builder.Property(s => s.ShopName).IsRequired().HasMaxLength(80);
            builder.Property(s => s.MobileNumber).HasMaxLength(16).IsUnicode(false);
            builder.Property(s => s.Email).IsRequired().HasMaxLength(120);
            builder.Property(s => s.Address).HasMaxLength(255);
            builder.Property(s => s.GSTNumber).HasMaxLength(15).IsUnicode(false); ;
            builder.Property(s => s.IsActive).HasDefaultValue(true);
            builder.Property(s => s.IsDeleted).HasDefaultValue(false);
            builder.Property(s => s.CreatedAt).HasDefaultValueSql("SYSDATETIME()");

        }
    }
}

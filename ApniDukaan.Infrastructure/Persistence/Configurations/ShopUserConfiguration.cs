using ApniDukaan.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApniDukaan.Infrastructure.Persistence.Configurations
{
    public class ShopUserConfiguration : IEntityTypeConfiguration<ShopUser>
    {
        public void Configure(EntityTypeBuilder<ShopUser> builder)
        {
            builder.HasKey(s => s.ShopUserId);
            builder.HasOne<User>().WithMany().HasForeignKey(s => s.UserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne<Role>().WithMany().HasForeignKey(s => s.RoleId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne<Shop>().WithMany().HasForeignKey(s => s.ShopId).OnDelete(DeleteBehavior.Restrict);
            builder.Property(s => s.IsActive).HasDefaultValue(true);
            builder.Property(s => s.IsDeleted).HasDefaultValue(false);
            builder.Property(s => s.CreatedAt).HasDefaultValueSql("SYSDATETIME()");
            builder.HasIndex(su => new { su.ShopId, su.UserId })
       .IsUnique();
        }
    }
}

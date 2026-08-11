using ApniDukaan.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApniDukaan.Infrastructure.Persistence.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.RoleId);
            builder.Property(r => r.RoleName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(r => r.IsActive).HasDefaultValue(true);

        }
    }
}

using CelilCavus.GreenHosting.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelilCavus.GreenHosting.Models.Configuration
{
    public class DeticatedServerConfiguration : IEntityTypeConfiguration<DedicatedServer>
    {
        public void Configure(EntityTypeBuilder<DedicatedServer> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();

            builder.Property(x=>x.Title).IsRequired();
            builder.Property(x=>x.Title).HasMaxLength(100);

            builder.Property(x=>x.Icon).IsRequired();
            builder.Property(x=>x.Icon).HasMaxLength(100);

            builder.Property(x=>x.Description).IsRequired();
            builder.Property(x=>x.Description).HasMaxLength(50);
        }
    }
}
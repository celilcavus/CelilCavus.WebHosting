using CelilCavus.GreenHosting.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelilCavus.GreenHosting.Models.Configuration
{
    public class AboutConfiguration : IEntityTypeConfiguration<AboutUs>
    {
        public void Configure(EntityTypeBuilder<AboutUs> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();
            
            builder.Property(x=>x.Header).IsRequired();
            builder.Property(x=>x.Header).HasMaxLength(50);

            builder.Property(x=>x.Description).IsRequired();
            builder.Property(x=>x.Description).HasMaxLength(int.MaxValue);

            builder.Property(x=>x.Image).IsRequired();
            builder.Property(x=>x.Image).HasMaxLength(100);
        }
    }
}
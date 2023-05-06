using CelilCavus.GreenHosting.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelilCavus.GreenHosting.Models.Configuration
{
    public class TestimonialConfiguration : IEntityTypeConfiguration<Testimonial>
    {
        public void Configure(EntityTypeBuilder<Testimonial> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Id);

            builder.Property(x=>x.Name).IsRequired();
            builder.Property(x=>x.Name).HasMaxLength(50);

            builder.Property(x=>x.Description).IsRequired();
            builder.Property(x=>x.Description).HasMaxLength(100);

            builder.Property(x=>x.Profession).IsRequired();
            builder.Property(x=>x.Profession).HasMaxLength(100);
        }
    }
}
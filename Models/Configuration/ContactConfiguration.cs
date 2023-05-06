using CelilCavus.GreenHosting.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelilCavus.GreenHosting.Models.Configuration
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();

            builder.Property(x=>x.Name).IsRequired();
            builder.Property(x=>x.Name).HasMaxLength(100);

            builder.Property(x=>x.Email).IsRequired();
            builder.Property(x=>x.Email).HasMaxLength(100);

            builder.Property(x=>x.Subject).IsRequired();
            builder.Property(x=>x.Subject).HasMaxLength(50);

            builder.Property(x=>x.Message).IsRequired();
            builder.Property(x=>x.Message).HasMaxLength(500);
        }
    }
}
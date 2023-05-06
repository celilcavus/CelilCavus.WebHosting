using CelilCavus.GreenHosting.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelilCavus.GreenHosting.Models.Configuration
{
    public class CustomerSupportConfiguration : IEntityTypeConfiguration<CustomerSupport>
    {
        public void Configure(EntityTypeBuilder<CustomerSupport> builder)
        {
           builder.HasKey(x=>x.Id);
           builder.Property(x=>x.Id).UseIdentityColumn();

           builder.Property(x=>x.Mail).IsRequired();
           builder.Property(x=>x.Mail).HasMaxLength(50);

           builder.Property(x=>x.PhoneNumber).IsRequired();
           builder.Property(x=>x.PhoneNumber).HasMaxLength(50);

           builder.Property(x=>x.Adress).IsRequired();
           builder.Property(x=>x.Adress).HasMaxLength(250);
        }
    }
}
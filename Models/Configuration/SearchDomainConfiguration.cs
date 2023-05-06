using CelilCavus.GreenHosting.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelilCavus.GreenHosting.Models.Configuration
{
    public class SearchDomainConfiguration : IEntityTypeConfiguration<SearchDomain>
    {
        public void Configure(EntityTypeBuilder<SearchDomain> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();


            builder.Property(x=>x.DomainName).IsRequired();
            builder.Property(x=>x.DomainName).HasMaxLength(150);
        }
    }
}
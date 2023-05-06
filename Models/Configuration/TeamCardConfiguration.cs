using CelilCavus.GreenHosting.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelilCavus.GreenHosting.Models.Configuration
{
    public class TeamCardConfiguration : IEntityTypeConfiguration<TeamCards>
    {
        public void Configure(EntityTypeBuilder<TeamCards> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();

            builder.Property(x=>x.Name).IsRequired();
            builder.Property(x=>x.Name).HasMaxLength(50);

            builder.Property(x=>x.Image).IsRequired();
            builder.Property(x=>x.Image).HasMaxLength(100);

            builder.Property(x=>x.Description).IsRequired();
            builder.Property(x=>x.Description).HasMaxLength(300);
        }
    }
}
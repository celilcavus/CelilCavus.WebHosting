using CelilCavus.GreenHosting.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CelilCavus.GreenHosting.Models.Configuration
{
    public class HostingCardPlanConfiguration : IEntityTypeConfiguration<HostingCardPlan>
    {
        public void Configure(EntityTypeBuilder<HostingCardPlan> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.OfferRate).IsRequired();

            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Price).HasColumnType("decimal(10,2)");

            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(150);

            builder.Property(x => x.Property1).IsRequired();
            builder.Property(x => x.Property1).HasMaxLength(50);

            builder.Property(x => x.Property2).IsRequired();
            builder.Property(x => x.Property2).HasMaxLength(50);

            builder.Property(x => x.Property3).IsRequired();
            builder.Property(x => x.Property3).HasMaxLength(50);

            builder.Property(x => x.Property4).IsRequired();
            builder.Property(x => x.Property4).HasMaxLength(50);

            builder.Property(x => x.Property5).IsRequired();
            builder.Property(x => x.Property5).HasMaxLength(50);

            builder.Property(x => x.Property6).IsRequired();
            builder.Property(x => x.Property6).HasMaxLength(50);

        }
    }
}
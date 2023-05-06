using CelilCavus.GreenHosting.Entitys;
using CelilCavus.GreenHosting.Models.Configuration;
using Microsoft.EntityFrameworkCore;

namespace CelilCavus.GreenHosting.Models.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
            
        }

        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<CustomerSupport> CustomerSupports { get; set; }
        public DbSet<SharedServer> SharedServers { get; set; }
        public DbSet<HostingCardPlan> HostingCardPlans { get; set; }
        public DbSet<SearchDomain> SearchDomains { get; set; }
        public DbSet<TeamCards> TeamCards { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<DedicatedServer> DedicatedServers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AboutConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerSupportConfiguration());
            modelBuilder.ApplyConfiguration(new DeticatedServerConfiguration());
            modelBuilder.ApplyConfiguration(new HostingCardPlanConfiguration());
            modelBuilder.ApplyConfiguration(new SearchDomainConfiguration());
            modelBuilder.ApplyConfiguration(new SharedServerConfiguration());
            modelBuilder.ApplyConfiguration(new TeamCardConfiguration());
            modelBuilder.ApplyConfiguration(new TestimonialConfiguration());
        }
    }
}
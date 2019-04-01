using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SaveBridge.Entities;

namespace SaveBridge.DataAccess.EF
{
    public class SaveBridgeContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<BuildingConstruction> BuildingConstructions { get; set; }

        public DbSet<BuildingConstructionType> BuildingConstructionTypes { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Breakdown> Breakdowns { get; set; }

        public DbSet<Renovation> Renovations { get; set; }

        public DbSet<Pressure> Pressures { get; set; }

        public DbSet<Vibration> Vibrations { get; set; }
        
        public SaveBridgeContext(DbContextOptions options) : base(options)
        {

        }
    }
}
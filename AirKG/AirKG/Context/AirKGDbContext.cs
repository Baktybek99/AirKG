using AirKG.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AirKG.Context
{
    public class AirKGDbContext : IdentityDbContext<User>
    {
        public AirKGDbContext(DbContextOptions options) : base(options) { }

        public DbSet<AirData> AirDatas { get; set; }

        public DbSet<District> Districts { get; set; }

        public DbSet<Sensor> Sensors { get; set; }
    }
}

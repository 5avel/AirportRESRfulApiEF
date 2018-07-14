using AirportRESRfulApi.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AirportRESRfulApi.DAL
{
    public class AirportContext : DbContext
    {
        private readonly IConfiguration configuration;

        public AirportContext(IConfiguration configuration, DbContextOptions<AirportContext> options) : base(options)
        {
            this.configuration = configuration;
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.configuration.GetConnectionString("AirportMSSQLlocaldb"));
        }

        

        public DbSet<Flight> Flights { get; set; }

            public DbSet<Ticket> Tickets { get; set; }

            public DbSet<Departure> Departures { get; set; }

                public DbSet<Plane> Planes { get; set; }
                    public DbSet<PlaneType> PlaneTypes { get; set; }

                public DbSet<Crew> Crews { get; set; }

                    public DbSet<Pilot> Pilots { get; set; }
                    public DbSet<Stewardess> Stewardesses { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AirportRESRfulApi.DAL.Models
{
    public class AirportContext : DbContext
    {
        IConfiguration _configuration;

        public AirportContext(IConfiguration configuration, DbContextOptions<AirportContext> options) : base(options)
        {
            _configuration = configuration;
            Database.EnsureCreated();
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

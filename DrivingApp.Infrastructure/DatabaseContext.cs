
using DrivingApp.Core;
using DrivingApp.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DrivingApp.Infrastructure
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Country>  Countries { get; set; }
        public DbSet<MileStone> MileStones { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Ride> Rides { get; set; }
        public DbSet<RideCondition> RideConditions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRide> UserRides { get; set; }
        public DbSet<UserRideComment> UserRideComments { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedData(modelBuilder);
            ApplyConfigurations(modelBuilder);
        }
    }
}

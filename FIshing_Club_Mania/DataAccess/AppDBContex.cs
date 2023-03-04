using FIshing_Club_Mania.DataModels;
using Microsoft.EntityFrameworkCore;

namespace FIshing_Club_Mania.DataAccess
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<FishingPlaceService> fishingPlace { get; set; }

    }
}

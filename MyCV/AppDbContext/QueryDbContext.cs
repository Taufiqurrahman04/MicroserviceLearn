using Microsoft.EntityFrameworkCore;
using MyCV.Entity;

namespace MyCV.AppDbContext
{
    public class QueryDbContext : DbContext
    {
        public QueryDbContext(DbContextOptions<QueryDbContext> options) : base(options)
        {
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Profile> Profiles { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using MyCV.Entity;

namespace WorkExperience.AppDbContext
{
    public class QueryDbContext : DbContext
    {
        public QueryDbContext(DbContextOptions<QueryDbContext> options) : base(options)
        {
            this.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<WorkExperience.Entity.Profile> Profiles { get; set; }
        public DbSet<MyWorkExperience> MyWorkExperiences { get; set; }
    }
}

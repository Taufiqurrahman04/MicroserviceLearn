using Microsoft.EntityFrameworkCore;
using MyCV.Entity;

namespace WorkExperience.AppDbContext
{
    public class CommandDbContext : DbContext
    {
        public CommandDbContext(DbContextOptions<CommandDbContext> options) : base(options)
        {
        }

        public DbSet<WorkExperience.Entity.Profile> Profiles { get; set; }
        public DbSet<MyWorkExperience> MyWorkExperiences { get; set; }
    }
}

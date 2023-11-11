using Microsoft.EntityFrameworkCore;
using MyCV.Entity;

namespace MyCV.AppDbContext
{
    public class CommandDbContext : DbContext
    {
        public CommandDbContext(DbContextOptions<CommandDbContext> options) : base(options)
        {

        }

        public DbSet<Profile> Profiles { get; set; }
    }
}

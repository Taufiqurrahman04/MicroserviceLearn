using Microsoft.EntityFrameworkCore;
namespace School.AppDbContext
{
    public class CommandDbContext : DbContext
    {
        public CommandDbContext(DbContextOptions<CommandDbContext> options) : base(options)
        {
        }
    }
}

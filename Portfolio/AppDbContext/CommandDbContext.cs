using Microsoft.EntityFrameworkCore;

namespace Portfolio.AppDbContext
{
    public class CommandDbContext : DbContext
    {
        public CommandDbContext(DbContextOptions<CommandDbContext> options) : base(options)
        {

        }
    }
}

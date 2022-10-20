using Microsoft.EntityFrameworkCore;

namespace APItaiRPS.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Move> Moves { get; set; }

        public DbSet<GameLog> GameLogs { get; set; }

    }
}

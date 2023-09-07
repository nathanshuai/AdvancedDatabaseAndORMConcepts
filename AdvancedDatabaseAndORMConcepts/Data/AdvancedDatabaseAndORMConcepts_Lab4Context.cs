using AdvancedDatabaseAndORMConcepts.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedDatabaseAndORMConcepts.Data
{
    namespace AdvancedDatabaseAndORMConcepts_Lab4.Data
    {
        public class AdvancedDatabaseAndORMConcepts_Lab4Context : DbContext
        {
            public AdvancedDatabaseAndORMConcepts_Lab4Context(DbContextOptions<AdvancedDatabaseAndORMConcepts_Lab4Context> options)
                : base(options)
            {
            }

            public DbSet<Client> Clients { get; set; } = default!;
            public DbSet<Room> Rooms { get; set; } = default!;
        }
    }
}

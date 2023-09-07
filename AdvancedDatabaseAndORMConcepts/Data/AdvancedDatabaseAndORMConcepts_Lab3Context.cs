using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdvancedDatabaseAndORMConcepts_Lab3.Models;

namespace AdvancedDatabaseAndORMConcepts_Lab3.Data
{
    public class AdvancedDatabaseAndORMConcepts_Lab3Context : DbContext
    {
        public AdvancedDatabaseAndORMConcepts_Lab3Context (DbContextOptions<AdvancedDatabaseAndORMConcepts_Lab3Context> options)
            : base(options)
        {
        }

        public DbSet<Course> Course { get; set; } = default!;
        public DbSet<Student> Students { get; set; } = default!;
    }
}

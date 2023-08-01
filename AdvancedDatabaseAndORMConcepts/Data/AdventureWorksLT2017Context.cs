using AdvancedDatabaseAndORMConcepts.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AdvancedDatabaseAndORMConcepts.Data
{
    public class AdventureWorksLT2017Context : DbContext
    {
        public AdventureWorksLT2017Context(DbContextOptions options) : base(options)
        {

        }
       
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;
    }
}

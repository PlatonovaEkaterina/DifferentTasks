using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Otdel> Otdels { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Sotrud> Sotruds { get; set; }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Otdel> Otdels { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Sotrud> Sotruds { get; set; }
    }
}

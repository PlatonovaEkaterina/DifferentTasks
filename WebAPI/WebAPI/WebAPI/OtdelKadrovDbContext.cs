using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI
{
    public class OtdelKadrovDbContext: DbContext
    {
        public OtdelKadrovDbContext(DbContextOptions<OtdelKadrovDbContext> options):base(options)
        {

        }

        public DbSet<Otdel> Otdels { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Sotrud> Sotruds { get; set; }
        
    }
}

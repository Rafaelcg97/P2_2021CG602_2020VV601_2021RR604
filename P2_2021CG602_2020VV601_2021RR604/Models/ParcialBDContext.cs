using Microsoft.EntityFrameworkCore;

namespace P2_2021CG602_2020VV601_2021RR604.Models
{
    public class ParcialBDContext:DbContext
    {
        public ParcialBDContext(DbContextOptions options) : base(options) 
        { 
        }
        public DbSet<casosReportados> casosReportados { get; set; } 
        public DbSet<departamentos> departamentos { get; set;}
        public DbSet<generos> generos { get; set; }
    }
}

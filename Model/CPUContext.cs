using Microsoft.EntityFrameworkCore;
using CPUDB.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUDB.Model
{
    public class CPUContext : DbContext
    {
        public DbSet<CPUItem> CPUs { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CPUModel> Models { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = CPUDB;Integrated Security=True;");
            } 
        }        
    }
}

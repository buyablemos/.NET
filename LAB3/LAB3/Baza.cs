using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB3
{
    internal class Pogody : DbContext
    {
        public DbSet<PoorDanePogodowe> Baza { get; set; }

        public Pogody()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=Pogody.db");
        }
       
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

    

    public void WyczyscBazeDanych()
        {
            Baza.RemoveRange(Baza);
            SaveChanges();

        }
    }
}

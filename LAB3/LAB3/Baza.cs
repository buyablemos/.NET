using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace LAB3
{
    internal class Pogoda : DbContext
    {
        public  DbSet<PoorDanePogodowe> BazaPogodowa { get; set; }

        public Pogoda()
        {
            Database.EnsureCreated();
           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string pathToDatabase = @"C:\Users\Dawid\source\repos\.NET\LAB3\Pogoda.db";
            optionsBuilder.UseSqlite($"DataSource={pathToDatabase}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }



        public void WyczyscBazeDanych()
        {
            BazaPogodowa.RemoveRange(BazaPogodowa);
            SaveChanges();

        }

        override public string ToString()
        {
            string output = "";
            foreach (var item in this.BazaPogodowa)
            {
                output+=item.ToString();
            }
            return output;

        }
        public List<PoorDanePogodowe> SortByTempDesc(bool DateFilter = false, DateTime dateTimeFilter = new DateTime())
        {
            if (DateFilter == false)
            {
                List<PoorDanePogodowe> sorted = BazaPogodowa.OrderByDescending(t => t.temp).ToList();
                return sorted;
            }
            else
            {
                List<PoorDanePogodowe> sorted = BazaPogodowa.OrderByDescending(t => t.temp).Where(t =>t.aktualnaDataCzas.Date==dateTimeFilter.Date).ToList();
                return sorted;
            }
 
        }
        public List<PoorDanePogodowe> SortByTempAsc(bool DateFilter = false, DateTime dateTimeFilter = new DateTime())
        {
            if (DateFilter == false)
            {
                List<PoorDanePogodowe> sortedTemperatures = BazaPogodowa.OrderBy(t => t.temp).ToList();
                return sortedTemperatures;
            }
            else
            {
                List<PoorDanePogodowe> sortedTemperatures = BazaPogodowa.OrderBy(t => t.temp).Where(t => t.aktualnaDataCzas.Date == dateTimeFilter.Date).ToList();
                return sortedTemperatures;
            }
        }
        public List<PoorDanePogodowe> FiltrByTempLower(float threshold, bool DateFilter = false, DateTime dateTimeFilter = new DateTime())
        {
            if (DateFilter == false)
            {
                List<PoorDanePogodowe> sortedTemperatures = BazaPogodowa.Where(t => t.temp <= threshold).ToList();
                return sortedTemperatures;
            }
            else
            {
                List<PoorDanePogodowe> sortedTemperatures = BazaPogodowa.Where(t => t.temp <= threshold).Where(t => t.aktualnaDataCzas.Date == dateTimeFilter.Date).ToList();
                return sortedTemperatures;
            }
        }
        public List<PoorDanePogodowe> FiltrByTempHigher(float threshold,bool DateFilter = false, DateTime dateTimeFilter = new DateTime())
        {
            if (DateFilter == false)
            {
                List<PoorDanePogodowe> sortedTemperatures = BazaPogodowa.Where(t => t.temp >= threshold).ToList();
                return sortedTemperatures;
            }
            else
            {
                List<PoorDanePogodowe> sortedTemperatures = BazaPogodowa.Where(t => t.temp >= threshold).Where(t => t.aktualnaDataCzas.Date == dateTimeFilter.Date).ToList();
                return sortedTemperatures;
            }
        }
        public List<PoorDanePogodowe> FiltrByTempLower_and_SortByTempAsc(float threshold, bool DateFilter = false, DateTime dateTimeFilter = new DateTime())
        {   if (DateFilter == false)
            {
                List<PoorDanePogodowe> sortedTemperatures = (BazaPogodowa.Where(t => t.temp <= threshold).OrderBy(t => t.temp)).ToList();
                return sortedTemperatures;
            }
            else
            {
                List<PoorDanePogodowe> sortedTemperatures = (BazaPogodowa.Where(t => t.temp <= threshold).OrderBy(t => t.temp)).Where(t => t.aktualnaDataCzas.Date == dateTimeFilter.Date).ToList();
                return sortedTemperatures;
            }
        }
        public List<PoorDanePogodowe> FiltrByTempLower_and_SortByTempDesc(float threshold, bool DateFilter = false, DateTime dateTimeFilter = new DateTime())
        {
            if (DateFilter == false)
            {
                List<PoorDanePogodowe> sortedTemperatures = (BazaPogodowa.Where(t => t.temp <= threshold).OrderByDescending(t => t.temp)).ToList();
                return sortedTemperatures;
            }
            else
            {
                List<PoorDanePogodowe> sortedTemperatures = (BazaPogodowa.Where(t => t.temp <= threshold).OrderByDescending(t => t.temp)).Where(t => t.aktualnaDataCzas.Date == dateTimeFilter.Date).ToList();
                return sortedTemperatures;
            }
        }
        public List<PoorDanePogodowe> FiltrByTempHigher_and_SortByTempAsc(float threshold, bool DateFilter = false, DateTime dateTimeFilter = new DateTime())
        {
            if (DateFilter == false)
            {
                List<PoorDanePogodowe> sortedTemperatures = (BazaPogodowa.Where(t => t.temp >= threshold).OrderBy(t => t.temp)).ToList();
                return sortedTemperatures;
            }
            else
            {
                List<PoorDanePogodowe> sortedTemperatures = (BazaPogodowa.Where(t => t.temp >= threshold).OrderBy(t => t.temp)).Where(t => t.aktualnaDataCzas.Date == dateTimeFilter.Date).ToList();
                return sortedTemperatures;
            }
        }
        public List<PoorDanePogodowe> FiltrByTempHigher_and_SortByTempDesc(float threshold, bool DateFilter = false, DateTime dateTimeFilter = new DateTime())
        {
            if (DateFilter == false)
            {
                List<PoorDanePogodowe> sortedTemperatures = (BazaPogodowa.Where(t => t.temp >= threshold).OrderByDescending(t => t.temp)).ToList();
                return sortedTemperatures;
            }
            else
            {
                List<PoorDanePogodowe> sortedTemperatures = (BazaPogodowa.Where(t => t.temp >= threshold).OrderByDescending(t => t.temp)).Where(t => t.aktualnaDataCzas.Date == dateTimeFilter.Date).ToList();
                return sortedTemperatures;
            }
        }

    }
}

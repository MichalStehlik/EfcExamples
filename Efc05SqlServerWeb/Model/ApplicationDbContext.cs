using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Efc05SqlServerWeb.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
        public DbSet<Exhibit> Exhibits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 1, Name = "Mona Lisa", Year = 1506 });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 2, Name = "Stvoření Adama", Year = 1512 });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 3, Name = "Dáma s hranostajem", Year = 1450 });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 4, Name = "Poslední večeře", Year = 1498 });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 5, Name = "Dívka s perlou", Year = 1665 });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 6, Name = "Slunečnice", Year = 1888 });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 7, Name = "Výkřik", Year = 1893 });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 8, Name = "Hvězdná noc", Year = 1889 });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 9, Name = "Zrození Venuše", Year = 1486 });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 10, Name = "Přetrvávání vzpomínky", Year = 1931 });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 11, Name = "Lekníny", Year = 1914 });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 12, Name = "Harlekýn", Year = 1923 });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 13, Name = "Noční hlídka", Year = 1642 });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 14, Name = "Moulin Rouge", Year = 1895 });
        }
    }
}

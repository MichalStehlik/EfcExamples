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
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 1, Name = "Mona Lisa" });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 2, Name = "Stvoření Adama" });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 3, Name = "Dáma s hranostajem" });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 4, Name = "Poslední večeře" });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 5, Name = "Dívka s perlou" });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 6, Name = "Slunečnice" });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 7, Name = "Výkřik" });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 8, Name = "Hvězdná noc" });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 9, Name = "Zrození Venuše" });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 10, Name = "Přetrvávání vzpomínky" });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 11, Name = "Lekníny" });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 12, Name = "Harlekín" });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 13, Name = "Noční hlídka" });
            modelBuilder.Entity<Exhibit>().HasData(new Exhibit { Id = 14, Name = "Moulin Rouge" });
        }
    }
}

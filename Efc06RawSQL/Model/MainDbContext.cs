using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Efc06RawSQL.Model
{
    class MainDbContext : DbContext
    {
        public DbSet<Region> Regions { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }
        public MainDbContext() : base()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Regions2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Region>().HasData(new Region { Id = 1, Name = "Hlavní město Praha" });
            modelBuilder.Entity<Region>().HasData(new Region { Id = 2, Name = "Liberecký kraj" });
            modelBuilder.Entity<Region>().HasData(new Region { Id = 3, Name = "Královéhradecký kraj" });
            modelBuilder.Entity<Region>().HasData(new Region { Id = 4, Name = "Ústecký kraj" });
            modelBuilder.Entity<Municipality>().HasData(new Municipality { Id = 1, Name = "Praha", RegionId = 1 });
            modelBuilder.Entity<Municipality>().HasData(new Municipality { Id = 2, Name = "Liberec", RegionId = 2 });
            modelBuilder.Entity<Municipality>().HasData(new Municipality { Id = 3, Name = "Jablonec nad Nisou", RegionId = 2 });
            modelBuilder.Entity<Municipality>().HasData(new Municipality { Id = 4, Name = "Semily", RegionId = 2 });
            modelBuilder.Entity<Municipality>().HasData(new Municipality { Id = 5, Name = "Frýdlant", RegionId = 2 });
            modelBuilder.Entity<Municipality>().HasData(new Municipality { Id = 6, Name = "Hejnice", RegionId = 2 });
            modelBuilder.Entity<Municipality>().HasData(new Municipality { Id = 7, Name = "Hradec Králové", RegionId = 3 });
            modelBuilder.Entity<Municipality>().HasData(new Municipality { Id = 8, Name = "Ústí nad Labem", RegionId = 4 });
            modelBuilder.Entity<Municipality>().HasData(new Municipality { Id = 9, Name = "Děčín", RegionId = 4 });
            modelBuilder.Entity<Municipality>().HasData(new Municipality { Id = 10, Name = "Teplice", RegionId = 4 });
        }
    }
}

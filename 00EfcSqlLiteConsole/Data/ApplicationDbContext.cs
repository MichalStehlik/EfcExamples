using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Efc00SqlLiteConsole.Data
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public ApplicationDbContext() : base()
        {
            Database.EnsureDeleted(); // smaže obsah souboru s databází
            Database.EnsureCreated(); // zajistí existenci struktury databáze v souboru
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=myDatabaseFile.sqlite");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>()
                .Property(p => p.FirstName)
                .HasMaxLength(10);
            modelBuilder.Entity<Student>().HasData(new Student { Id = 1, FirstName = "Alice", LastName = "Astra" }); // seed databáze
        }
    }
}

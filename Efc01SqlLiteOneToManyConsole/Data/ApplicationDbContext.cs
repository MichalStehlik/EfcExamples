using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Efc01SqlLiteOneToManyConsole.Data
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public ApplicationDbContext()
        {
            Database.EnsureDeleted(); // smaže obsah souboru s databází
            Database.EnsureCreated(); // zajistí existenci struktury databáze v souboru
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) 
        {
            options.UseSqlite(@"Data Source=myDatabaseFile.db");
            //options.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Classroom c1 = new Classroom { Id = 1, Name = "P1" };
            Classroom c2 = new Classroom { Id = 2, Name = "P2" };
            modelBuilder.Entity<Student>()
                .Property(p => p.FirstName)
                .HasMaxLength(10);
            modelBuilder.Entity<Classroom>().HasData(c1);
            modelBuilder.Entity<Classroom>().HasData(new Classroom { Id = 2, Name = "P2" });
            modelBuilder.Entity<Classroom>().HasData(new Classroom { Id = 3, Name = "P3" });
            modelBuilder.Entity<Classroom>().HasData(new Classroom { Id = 4, Name = "P4" });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 1, FirstName = "Alice", LastName = "Astra", ClassroomId = 1});
            modelBuilder.Entity<Student>().HasData(new Student { Id = 2, FirstName = "Bruce", LastName = "Banner", ClassroomId = 1 });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 3, FirstName = "Cyrus", LastName = "Creed", ClassroomId = 2 });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 4, FirstName = "Diane", LastName = "Drake", ClassroomId = 2 });
            modelBuilder.Entity<Student>().HasData(new Student { Id = 5, FirstName = "Emilia", LastName = "Evening", ClassroomId = 2 });
            base.OnModelCreating(modelBuilder);
        }
    } 
}

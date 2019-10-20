using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Efc04SqliteFluentAPIConsole.Data
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public ApplicationDbContext() : base()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=myDatabaseFile.sqlite");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            #region Další nastavení přes fluent API zápis
            // https://www.entityframeworktutorial.net/efcore/fluent-api-in-entity-framework-core.aspx
            // https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.modelbuilder?view=efcore-3.0
            // https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbset-1?view=efcore-3.0

            modelBuilder.Entity<Student>()
                .Property(s => s.FirstName)
                .HasMaxLength(30)
                .IsRequired();
            modelBuilder.Entity<Student>()
                .Property(s => s.LastName)
                .HasMaxLength(30)
                .HasDefaultValue("Doe");
            modelBuilder.Entity<Classroom>()
                .HasKey(c => c.ClassroomIdentificator);
            modelBuilder.Entity<Student>()
                .HasKey(s => s.StudentIdentificator);
            modelBuilder.Entity<Student>()
                .HasOne<Classroom>(s => s.Classroom)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.ClassroomId);
            #endregion
            #region Seed databáze
            // https://www.learnentityframeworkcore.com/migrations/seeding
            modelBuilder.Entity<Classroom>().HasData(new Classroom { ClassroomIdentificator = 1, Name = "P1" });
            modelBuilder.Entity<Classroom>().HasData(new Classroom { ClassroomIdentificator = 2, Name = "P2" });
            modelBuilder.Entity<Classroom>().HasData(new Classroom { ClassroomIdentificator = 3, Name = "P3" });
            modelBuilder.Entity<Classroom>().HasData(new Classroom { ClassroomIdentificator = 4, Name = "P4" });
            modelBuilder.Entity<Student>().HasData(new Student { StudentIdentificator = 1, FirstName = "Alice", LastName = "Astra", ClassroomId = 1 });
            modelBuilder.Entity<Student>().HasData(new Student { StudentIdentificator = 2, FirstName = "Bruce", LastName = "Banner", ClassroomId = 1 });
            modelBuilder.Entity<Student>().HasData(new Student { StudentIdentificator = 3, FirstName = "Cyrus", LastName = "Creed", ClassroomId = 2 });
            modelBuilder.Entity<Student>().HasData(new Student { StudentIdentificator = 4, FirstName = "Diane", LastName = "Drake", ClassroomId = 2 });
            modelBuilder.Entity<Student>().HasData(new Student { StudentIdentificator = 5, FirstName = "Emilia", LastName = "Evening", ClassroomId = 2 });
            #endregion
        }
    }
}

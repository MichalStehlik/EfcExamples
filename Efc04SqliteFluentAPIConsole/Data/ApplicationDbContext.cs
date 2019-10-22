using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Efc04SqliteFluentAPIConsole.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // nahrazeno konfigurací z Program.cs
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            #region Další nastavení přes fluent API zápis
            // https://www.entityframeworktutorial.net/efcore/fluent-api-in-entity-framework-core.aspx
            // https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.modelbuilder?view=efcore-3.0
            // https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbset-1?view=efcore-3.0
            // délka textu + povinné pole
            modelBuilder.Entity<Student>()
                .Property(s => s.FirstName)
                .HasMaxLength(30)
                .IsRequired();
            // defaultní hodnota
            modelBuilder.Entity<Student>()
                .Property(s => s.LastName)
                .HasMaxLength(30)
                .HasDefaultValue("Doe");
            // primární klíč
            modelBuilder.Entity<Classroom>()
                .HasKey(c => c.ClassroomIdentificator);
            modelBuilder.Entity<Student>()
                .HasKey(s => s.StudentIdentificator);
            // unikátní pole
            modelBuilder.Entity<Student>()
                .HasIndex(e => e.Email)
                .IsUnique();
            // vazba 1:N
            modelBuilder.Entity<Student>()
                .HasOne<Classroom>(s => s.Classroom)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.ClassroomId);
            #endregion
            #region Seed databáze
            modelBuilder.Entity<Classroom>().HasData(new Classroom { ClassroomIdentificator = 1, Name = "P1" });
            modelBuilder.Entity<Classroom>().HasData(new Classroom { ClassroomIdentificator = 2, Name = "P2" });
            modelBuilder.Entity<Classroom>().HasData(new Classroom { ClassroomIdentificator = 3, Name = "P3" });
            modelBuilder.Entity<Classroom>().HasData(new Classroom { ClassroomIdentificator = 4, Name = "P4" });
            modelBuilder.Entity<Student>().HasData(new Student { StudentIdentificator = 1, FirstName = "Alice", LastName = "Astra", Email = "a.a@school.cloud", ClassroomId = 1 });
            modelBuilder.Entity<Student>().HasData(new Student { StudentIdentificator = 2, FirstName = "Bruce", LastName = "Banner", Email = "b.b@school.cloud", ClassroomId = 1 });
            modelBuilder.Entity<Student>().HasData(new Student { StudentIdentificator = 3, FirstName = "Cyrus", LastName = "Creed", Email = "c.c@school.cloud", ClassroomId = 2 });
            modelBuilder.Entity<Student>().HasData(new Student { StudentIdentificator = 4, FirstName = "Diane", LastName = "Drake", Email = "d.d@school.cloud", ClassroomId = 2 });
            modelBuilder.Entity<Student>().HasData(new Student { StudentIdentificator = 5, FirstName = "Emilia", LastName = "Evening", Email = "e.e@school.cloud", ClassroomId = 2 });
            #endregion
        }
    }
}

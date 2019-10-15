using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Efc02SqliteManyToManyConsole.Data
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
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
            #region Další nastavení přes fluid zápis
            modelBuilder.Entity<MovieActor>().HasKey(ma => new { ma.MovieId, ma.ActorId });
            #endregion
            #region Seed databáze
            // https://www.learnentityframeworkcore.com/migrations/seeding
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 1, Name = "Joker" });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 2, Name = "Avengers: Endgame" });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 3, Name = "Avengers: Infinity War" });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 4, Name = "Spider-Man: Homecoming" });
            modelBuilder.Entity<Actor>().HasData(new Actor { Id = 1, FirstName = "Joaquin", LastName = "Phoenix" });
            modelBuilder.Entity<Actor>().HasData(new Actor { Id = 2, FirstName = "Robert", LastName = "Downey Jr."});
            modelBuilder.Entity<Actor>().HasData(new Actor { Id = 3, FirstName = "Chris", LastName = "Evans" });
            modelBuilder.Entity<Actor>().HasData(new Actor { Id = 4, FirstName = "Tom", LastName = "Holland"});
            modelBuilder.Entity<Actor>().HasData(new Actor { Id = 5, FirstName = "Scarlett", LastName = "Johansson" });
            modelBuilder.Entity<MovieActor>().HasData(new MovieActor { MovieId = 1, ActorId = 1 });
            modelBuilder.Entity<MovieActor>().HasData(new MovieActor { MovieId = 2, ActorId = 2 });
            modelBuilder.Entity<MovieActor>().HasData(new MovieActor { MovieId = 2, ActorId = 3 });
            modelBuilder.Entity<MovieActor>().HasData(new MovieActor { MovieId = 2, ActorId = 4 });
            modelBuilder.Entity<MovieActor>().HasData(new MovieActor { MovieId = 2, ActorId = 5 });
            modelBuilder.Entity<MovieActor>().HasData(new MovieActor { MovieId = 3, ActorId = 2 });
            modelBuilder.Entity<MovieActor>().HasData(new MovieActor { MovieId = 3, ActorId = 3 });
            modelBuilder.Entity<MovieActor>().HasData(new MovieActor { MovieId = 3, ActorId = 4 });
            modelBuilder.Entity<MovieActor>().HasData(new MovieActor { MovieId = 3, ActorId = 5 });
            modelBuilder.Entity<MovieActor>().HasData(new MovieActor { MovieId = 4, ActorId = 2 });
            modelBuilder.Entity<MovieActor>().HasData(new MovieActor { MovieId = 4, ActorId = 4 });
            #endregion
        }
    }
}

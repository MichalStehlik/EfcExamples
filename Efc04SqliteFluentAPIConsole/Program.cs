using Efc04SqliteFluentAPIConsole.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;

namespace Efc04SqliteFluentAPIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Konfigurace verze 1
            // načtení konfigurace z externího .json souboru
            // https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.configuration.configurationbuilder?view=dotnet-plat-ext-3.0
            /*
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // hledá konfiguraci v \bin\Debug\netcoreapp2.2
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = configurationBuilder.Build();
           
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlite(connectionString); 
            var db = new ApplicationDbContext(builder.Options);
            */
            #endregion
            #region Konfigurace verze 2
            // konfigurační soubor je načítán továrnou ApplicationDbContextFactory
            // odstraněna duplicita kódu
            var db = new ApplicationDbContextFactory().CreateDbContext(new string[0]);
            #endregion
            db.Students.Add(new Student { FirstName = "Fiona", LastName = "Ferarri", Email = "f.f@school.cloud", ClassroomId = 1 });
            db.Students.Add(new Student { FirstName = "George", LastName = "Grayson", Email = "g.g@school.cloud", ClassroomId = 2 });
            db.Students.Add(new Student { FirstName = "Henry", LastName = "Hudson", Email = "h.h@school.cloud", ClassroomId = 2 });
            db.Students.Add(new Student { FirstName = "Christine", Email = "ch.d@school.cloud", ClassroomId = 2 });
            db.SaveChanges();
            foreach (var s in db.Students.Include(s => s.Classroom).ToList())
            {
                Console.WriteLine(s.StudentIdentificator + ":" + s.FirstName + " " + s.LastName + " (" + s.Classroom.Name + ")");
            }
            foreach (var c in db.Classrooms.Include(c => c.Students).ToList())
            {
                Console.WriteLine("-- " + c.Name + " --");
                foreach (var s in c.Students.OrderBy(st => st.FirstName))
                {
                    Console.WriteLine(s.FirstName + " " + s.LastName);
                }
            }
        }
    }
}

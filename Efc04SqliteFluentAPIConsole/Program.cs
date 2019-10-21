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
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = configurationBuilder.Build();

            Console.WriteLine(configuration.GetConnectionString("Storage"));
            Console.ReadKey();
            var db = new ApplicationDbContext(configuration);
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

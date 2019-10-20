using Efc04SqliteFluentAPIConsole.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Efc04SqliteFluentAPIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ApplicationDbContext();
            db.Students.Add(new Student { FirstName = "Fiona", LastName = "Ferarri", ClassroomId = 1 });
            db.Students.Add(new Student { FirstName = "George", LastName = "Grayson", ClassroomId = 2 });
            db.Students.Add(new Student { FirstName = "Henry", LastName = "Hudson", ClassroomId = 2 });
            db.Students.Add(new Student { FirstName = "Christine", ClassroomId = 2 });
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

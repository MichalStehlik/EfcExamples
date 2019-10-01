using Efc00SqlLiteConsole.Data;
using System;
using System.Linq;

namespace Efc00SqlLiteConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ApplicationDbContext();
            Console.WriteLine("-- Listing content of database");
            foreach (var s in db.Students.ToList())
            {
                Console.WriteLine(s.Id + ":" + s.FirstName + " " + s.LastName);
            }

            Console.WriteLine("-- Adding a new item");
            Console.Write("FirstName:");
            string fn = Console.ReadLine();
            Console.Write("LastName:");
            string ln = Console.ReadLine();
            db.Students.Add(new Student { FirstName = fn, LastName = ln });
            db.SaveChanges();

            Console.WriteLine("-- Listing content of database");
            foreach (var s in db.Students.ToList())
            {
                Console.WriteLine(s.Id + ":" + s.FirstName + " " + s.LastName);
            }

            Console.WriteLine("-- Fetching Record With Id 1");
            Student student = db.Students.Find(1);
            if (student != null)
            {
                Console.WriteLine(student.LastName + " " + student.FirstName);

                Console.WriteLine("-- Changing Record With Id 1");
                student.LastName = "Xavier";
                Console.WriteLine(student.LastName + " " + student.FirstName);
                db.SaveChanges();
                Console.WriteLine(student.LastName + " " + student.FirstName);

                Console.WriteLine("-- Deleting Record With Id 1");
                Student studentToBeRemoved = db.Students.Find(1);
                db.Students.Remove(studentToBeRemoved);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("No record with Id 1");
            }

            Console.WriteLine("-- Listing content of database");
            foreach (var s in db.Students.ToList())
            {
                Console.WriteLine(s.Id + ":" + s.FirstName + " " + s.LastName);
            }
            
        }
    }
}

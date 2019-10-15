using Efc02SqliteManyToManyConsole.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Efc02SqliteManyToManyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ApplicationDbContext();
            foreach (var m in db.Movies.Include(m => m.MovieActors).ThenInclude(m => m.Actor).ToList())
            {
                Console.WriteLine("-- " + m.Name + " --");
                foreach (var a in m.MovieActors.OrderBy(a => a.Actor.LastName))
                {
                    Console.WriteLine(a.Actor.FirstName + " " + a.Actor.LastName);
                }
            }
        }
    }
}

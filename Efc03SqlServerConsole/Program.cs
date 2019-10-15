using Efc03SqlServerConsole.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Efc03SqlServerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ApplicationDbContext();
            foreach (var r in db.Regions.Include(r => r.Municipalities).OrderBy(r => r.Name).ToList())
            {
                Console.WriteLine("-- " + r.Name + " --");
                foreach (var m in r.Municipalities.OrderBy(mun => mun.Name))
                {
                    Console.WriteLine(m.Name);
                }
            }
        }
    }
}

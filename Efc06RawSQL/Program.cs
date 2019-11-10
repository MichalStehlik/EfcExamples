using Efc06RawSQL.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace Efc06RawSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://docs.microsoft.com/cs-cz/ef/core/querying/raw-sql
            // https://www.learnentityframeworkcore.com/raw-sql
            // FromSqlRaw
            // FromSqlInterpolated
            // ExecuteSqlRaw
            // ExecuteSqlInterpolated
            // !!!
            // SQL musí vracet přesně stejné sloupce jako cílový typ
            // SQL nesmí samo provádět JOIN, lze ho ale skládat s LINQ .Include

            var db = new MainDbContext();

            // Jednoduchý SELECT
            var regions = db.Regions.FromSqlRaw("SELECT * FROM dbo.Regions").ToList();
            foreach (var r in regions)
            {
                Console.WriteLine("- " + r.Name);
            }
            Console.WriteLine();

            // INSERT
            var commandText = "INSERT Regions (Name) VALUES (@RegionName)";
            var name = new SqlParameter("@RegionName", "Úplně nový kraj");
            db.Database.ExecuteSqlRaw(commandText, name);

            // Filtrovaný výpis s připojením obcí
            // nelze SELECT * FROM Regions JOIN Municipalities ON Municipalities.RegionId = Regions.Id WHERE Name LIKE {0}
            string filter = "%kraj%";
            var someRegions = db.Regions.FromSqlRaw("SELECT * FROM Regions WHERE Name LIKE {0}", filter).Include(r => r.Municipalities).ToList();
            foreach (var r in someRegions)
            {
                Console.WriteLine("- " + r.Name);
                foreach (var m in r.Municipalities.OrderBy(mun => mun.Name))
                {
                    Console.WriteLine(m.Name);
                }
            }
        }
    }
}

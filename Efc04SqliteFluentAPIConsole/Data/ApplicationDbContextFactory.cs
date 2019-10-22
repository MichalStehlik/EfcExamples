using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Efc04SqliteFluentAPIConsole.Data
{
    /// <summary>
    /// Vytváří ApplicationDbContext
    /// Je nutná aby se v tomto scénáři dal provádět příkaz Update-Database
    /// Slouží také pro získání konfigurace databáze pro samotnou aplikaci
    /// </summary>
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // hledá konfiguraci v \bin\Debug\netcoreapp2.2
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = configurationBuilder.Build();

            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            builder.UseSqlite(connectionString);
            return new ApplicationDbContext(builder.Options);
        }
    }
}

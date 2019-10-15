# 03 - Připojení k SQL Serveru
1. Instalace rozšíření

    NuGet: Install-Package Microsoft.EntityFrameworkCore.SqlServer
    
    NuGet: Install-Package Microsoft.EntityFrameworkCore.Tools
    
    NuGet: Install-Package Microsoft.EntityFrameworkCore.Design
    
2. Vytvoření modelu

3. Založení databáze

- VS: View\SQL Server Object Explorer
- SQL Server\localdb\Databases
- Add Database (např. Regions)
- pravé tlačítko myši\Properties
- zkopírovat ConnectionString

4. Vytvoření DbContext

Data Source je zkopírovaný ConnectionString

5. Vytvoření první Migrace

    NuGet: Add-Migration Init (pozor na nastavění Default Project v Package Manager Console)

6. Promítnutí migrace do databáze

    NuGet: Update-Database

7. Naprogramovat aplikaci

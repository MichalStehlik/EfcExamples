# 03 - Připojení k SQL Serveru
1. Instalace rozšíření

    1. NuGet: `Install-Package Microsoft.EntityFrameworkCore.SqlServer`
    
    1. NuGet: `Install-Package Microsoft.EntityFrameworkCore.Tools`
    
    1. NuGet: `Install-Package Microsoft.EntityFrameworkCore.Design`
    
2. Vytvoření [modelu](https://github.com/MichalStehlik/EfcExamples/tree/master/Efc03SqlServerConsole/Data)

3. Založení databáze

- VS: View\SQL Server Object Explorer
- SQL Server\localdb\Databases
- Add Database (např. Regions)
- pravé tlačítko myši\Properties
- zkopírovat *ConnectionString*

4. Vytvoření [DbContext](https://github.com/MichalStehlik/EfcExamples/blob/master/Efc03SqlServerConsole/Data/ApplicationDbContext.cs)

Data Source je zkopírovaný *ConnectionString*

5. Vytvoření první Migrace
 1. NuGet: `Add-Migration Init` (pozor na nastavení Default Project v Package Manager Console)

6. Promítnutí migrace do databáze
 1. NuGet: `Update-Database`

7. Naprogramovat aplikaci

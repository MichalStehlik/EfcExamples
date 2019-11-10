# Příklady k výuce Entity Framework Core
## Ukázkové projekty
### 00 - [Připojení k Sqlite a základní manipulace s daty](https://github.com/MichalStehlik/EfcExamples/tree/master/00EfcSqlLiteConsole)
Ukázka patrně nejjednoduššího možného přístupu k SQLite databázi z .NET konzolové aplikace. Ukázka je založena na jediné tabulce
na které se provádějí standardní operace čtení, vytvoření, editace a smazání záznamu.
### 01 - [Ukázka vytvoření relace 1:N v databázi](https://github.com/MichalStehlik/EfcExamples/tree/master/Efc01SqlLiteOneToManyConsole)
Příklad, jak propojit více tabulek ve schématu 1:N. Zde již jde jen o čtení ze dvou databázových tabulek.
### 02 - [Ukazka vytvoření relace N:M v databázi](https://github.com/MichalStehlik/EfcExamples/tree/master/Efc02SqliteManyToManyConsole)
Příklad realizace propojení tabulek v relaci N:M. V tomto případě je vytvořena nová vázací tabulka a na ni jsou připojeny obě datové tabulky.
### 03 - [Připojení k SQL Serveru](https://github.com/MichalStehlik/EfcExamples/tree/master/Efc03SqlServerConsole)
Ukázka připojení k jinému než SQLite "serveru". Je použit SQL Server vestavěný ve Visual Studiu, jde opět o ukázku na dvou tabulkách.
- [Poznámky a postup](https://github.com/MichalStehlik/EfcExamples/blob/master/Efc03SqlServerConsole/Docs/Start.md)
### 04 - [Fluent API a konfigurace databáze ze souboru](https://github.com/MichalStehlik/EfcExamples/tree/master/Efc04SqliteFluentAPIConsole)
Již poměrně komplikovaný příklad si klade za cíl odstranit definici připojovacího řetězce z kódu ApplicationDbContext a její umístění do souboru "appsettings.json" tak, aby nadále fungoval mechanismus migrací. Zároveň jsou zde předvedeny možnosti konfigurace entit nikoliv přes anotace, ale přes Fluent API. Je zde opět využita SQLite databáze.
### 05 - [ASP.NET Razor Pages](https://github.com/MichalStehlik/EfcExamples/tree/master/Efc05SqlServerWeb)
Zkonfigurovaná a automaticky scaffoldovaná verze webové aplikace o jedné tabulce pracující s lokálním SQL Serverem. Obsahuje výpis světových obrazů s fungujícím řazením a filtrováním podle jména.
### 06 - [Raw SQL](https://github.com/MichalStehlik/EfcExamples/tree/master/Efc06RawSQL)
Konzolová aplikace ukazující (omezené) možnosti komunikace s SQL Serverem čistě prostřednictvím dotazů SQL.

## Dokumentace k dalšímu studiu
* https://docs.microsoft.com/cs-cz/ef/core/ (MSDN)
* https://docs.microsoft.com/cs-cz/ef/core/providers/?tabs=dotnet-core-cli (poskytovatelé databází)
* https://www.learnentityframeworkcore.com/ (Tutoriál)

using Microsoft.EntityFrameworkCore.Migrations;

namespace Efc05SqlServerWeb.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exhibits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exhibits", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Exhibits",
                columns: new[] { "Id", "Name", "Year" },
                values: new object[,]
                {
                    { 1, "Mona Lisa", null },
                    { 2, "Stvoření Adama", null },
                    { 3, "Dáma s hranostajem", null },
                    { 4, "Poslední večeře", null },
                    { 5, "Dívka s perlou", null },
                    { 6, "Slunečnice", null },
                    { 7, "Výkřik", null },
                    { 8, "Hvězdná noc", null },
                    { 9, "Zrození Venuše", null },
                    { 10, "Přetrvávání vzpomínky", null },
                    { 11, "Lekníny", null },
                    { 12, "Harlekín", null },
                    { 13, "Noční hlídka", null },
                    { 14, "Moulin Rouge", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exhibits");
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Efc03SqlServerConsole.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Municipalities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    RegionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipalities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Municipalities_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Hlavní město Praha" },
                    { 2, "Liberecký kraj" },
                    { 3, "Královéhradecký kraj" },
                    { 4, "Ústecký kraj" }
                });

            migrationBuilder.InsertData(
                table: "Municipalities",
                columns: new[] { "Id", "Name", "RegionId" },
                values: new object[,]
                {
                    { 1, "Praha", 1 },
                    { 2, "Liberec", 2 },
                    { 3, "Jablonec nad Nisou", 2 },
                    { 4, "Semily", 2 },
                    { 5, "Frýdlant", 2 },
                    { 6, "Hejnice", 2 },
                    { 7, "Hradec Králové", 3 },
                    { 8, "Ústí nad Labem", 4 },
                    { 9, "Děčín", 4 },
                    { 10, "Teplice", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Municipalities_RegionId",
                table: "Municipalities",
                column: "RegionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Municipalities");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Efc04SqliteFluentAPIConsole.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classrooms",
                columns: table => new
                {
                    ClassroomIdentificator = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classrooms", x => x.ClassroomIdentificator);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentIdentificator = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: true, defaultValue: "Doe"),
                    Email = table.Column<string>(nullable: true),
                    ClassroomId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentIdentificator);
                    table.ForeignKey(
                        name: "FK_Students_Classrooms_ClassroomId",
                        column: x => x.ClassroomId,
                        principalTable: "Classrooms",
                        principalColumn: "ClassroomIdentificator",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "ClassroomIdentificator", "Name" },
                values: new object[] { 1, "P1" });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "ClassroomIdentificator", "Name" },
                values: new object[] { 2, "P2" });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "ClassroomIdentificator", "Name" },
                values: new object[] { 3, "P3" });

            migrationBuilder.InsertData(
                table: "Classrooms",
                columns: new[] { "ClassroomIdentificator", "Name" },
                values: new object[] { 4, "P4" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentIdentificator", "ClassroomId", "Email", "FirstName", "LastName" },
                values: new object[] { 1, 1, "a.a@school.cloud", "Alice", "Astra" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentIdentificator", "ClassroomId", "Email", "FirstName", "LastName" },
                values: new object[] { 2, 1, "b.b@school.cloud", "Bruce", "Banner" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentIdentificator", "ClassroomId", "Email", "FirstName", "LastName" },
                values: new object[] { 3, 2, "c.c@school.cloud", "Cyrus", "Creed" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentIdentificator", "ClassroomId", "Email", "FirstName", "LastName" },
                values: new object[] { 4, 2, "d.d@school.cloud", "Diane", "Drake" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentIdentificator", "ClassroomId", "Email", "FirstName", "LastName" },
                values: new object[] { 5, 2, "e.e@school.cloud", "Emilia", "Evening" });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassroomId",
                table: "Students",
                column: "ClassroomId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_Email",
                table: "Students",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Classrooms");
        }
    }
}

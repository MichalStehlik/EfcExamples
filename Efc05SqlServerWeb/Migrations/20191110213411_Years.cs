using Microsoft.EntityFrameworkCore.Migrations;

namespace Efc05SqlServerWeb.Migrations
{
    public partial class Years : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: 1506);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: 1512);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: 1450);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: 1498);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Year",
                value: 1665);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Year",
                value: 1888);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Year",
                value: 1893);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Year",
                value: 1889);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Year",
                value: 1486);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Year",
                value: 1931);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Year",
                value: 1914);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "Year" },
                values: new object[] { "Harlekýn", 1923 });

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Year",
                value: 1642);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Year",
                value: 1895);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 1,
                column: "Year",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 2,
                column: "Year",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 3,
                column: "Year",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 4,
                column: "Year",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 5,
                column: "Year",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 6,
                column: "Year",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 7,
                column: "Year",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 8,
                column: "Year",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 9,
                column: "Year",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 10,
                column: "Year",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 11,
                column: "Year",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "Year" },
                values: new object[] { "Harlekín", null });

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 13,
                column: "Year",
                value: null);

            migrationBuilder.UpdateData(
                table: "Exhibits",
                keyColumn: "Id",
                keyValue: 14,
                column: "Year",
                value: null);
        }
    }
}

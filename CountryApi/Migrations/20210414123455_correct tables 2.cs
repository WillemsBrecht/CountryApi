using Microsoft.EntityFrameworkCore.Migrations;

namespace CountryApi.Migrations
{
    public partial class correcttables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Countries_CountryISOCode",
                table: "Languages");

            migrationBuilder.RenameColumn(
                name: "CountryISOCode",
                table: "Languages",
                newName: "countryISOCode");

            migrationBuilder.RenameIndex(
                name: "IX_Languages_CountryISOCode",
                table: "Languages",
                newName: "IX_Languages_countryISOCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Countries_countryISOCode",
                table: "Languages",
                column: "countryISOCode",
                principalTable: "Countries",
                principalColumn: "ISOCode",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Countries_countryISOCode",
                table: "Languages");

            migrationBuilder.RenameColumn(
                name: "countryISOCode",
                table: "Languages",
                newName: "CountryISOCode");

            migrationBuilder.RenameIndex(
                name: "IX_Languages_countryISOCode",
                table: "Languages",
                newName: "IX_Languages_CountryISOCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Countries_CountryISOCode",
                table: "Languages",
                column: "CountryISOCode",
                principalTable: "Countries",
                principalColumn: "ISOCode",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

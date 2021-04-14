using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CountryApi.Migrations
{
    public partial class Deletedtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryLanguages");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ISOCode", "Name", "Population" },
                values: new object[,]
                {
                    { "BE", "Belgium", 0 },
                    { "FR", "France", 0 },
                    { "DE", "Germany", 0 },
                    { "NL", "Netherlands", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ISOCode",
                keyValue: "BE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ISOCode",
                keyValue: "DE");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ISOCode",
                keyValue: "FR");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ISOCode",
                keyValue: "NL");

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryISOCode = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageId);
                    table.ForeignKey(
                        name: "FK_Languages_Countries_CountryISOCode",
                        column: x => x.CountryISOCode,
                        principalTable: "Countries",
                        principalColumn: "ISOCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CountryLanguages",
                columns: table => new
                {
                    ISOCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryLanguages", x => new { x.ISOCode, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_CountryLanguages_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CountryLanguages_LanguageId",
                table: "CountryLanguages",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_CountryISOCode",
                table: "Languages",
                column: "CountryISOCode");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CountryApi.Migrations
{
    public partial class correcttables3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "LanguageId1",
                table: "Languages",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_LanguageId1",
                table: "Languages",
                column: "LanguageId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Countries_CountryISOCode",
                table: "Languages",
                column: "CountryISOCode",
                principalTable: "Countries",
                principalColumn: "ISOCode",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Languages_LanguageId1",
                table: "Languages",
                column: "LanguageId1",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Countries_CountryISOCode",
                table: "Languages");

            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Languages_LanguageId1",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Languages_LanguageId1",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "LanguageId1",
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
    }
}

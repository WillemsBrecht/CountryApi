using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CountryApi.Migrations
{
    public partial class correcttables4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Languages_LanguageId1",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Languages_LanguageId1",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "LanguageId1",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "ISOCode",
                table: "Cities");

            migrationBuilder.CreateIndex(
                name: "IX_CountryLanguages_LanguageId",
                table: "CountryLanguages",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryLanguages_Languages_LanguageId",
                table: "CountryLanguages",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCountries_Users_UserId",
                table: "UserCountries",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryLanguages_Languages_LanguageId",
                table: "CountryLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCountries_Users_UserId",
                table: "UserCountries");

            migrationBuilder.DropIndex(
                name: "IX_CountryLanguages_LanguageId",
                table: "CountryLanguages");

            migrationBuilder.AddColumn<Guid>(
                name: "LanguageId1",
                table: "Languages",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ISOCode",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_LanguageId1",
                table: "Languages",
                column: "LanguageId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Languages_LanguageId1",
                table: "Languages",
                column: "LanguageId1",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

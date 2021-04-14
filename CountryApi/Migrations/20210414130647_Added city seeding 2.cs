using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CountryApi.Migrations
{
    public partial class Addedcityseeding2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("62ffd2b8-dbf0-456b-be65-48f3a4adcd08"));

            migrationBuilder.DropColumn(
                name: "ISOCode",
                table: "Cities");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CountryISOCode", "Name", "Population" },
                values: new object[] { new Guid("c269c938-f236-4746-9eaa-3f384e41e375"), null, "Bruges", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("c269c938-f236-4746-9eaa-3f384e41e375"));

            migrationBuilder.AddColumn<string>(
                name: "ISOCode",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CountryISOCode", "ISOCode", "Name", "Population" },
                values: new object[] { new Guid("62ffd2b8-dbf0-456b-be65-48f3a4adcd08"), null, "BE", "Bruges", 117260 });
        }
    }
}

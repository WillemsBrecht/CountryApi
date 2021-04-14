using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CountryApi.Migrations
{
    public partial class Addedcityseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("62ffd2b8-dbf0-456b-be65-48f3a4adcd08"));

            migrationBuilder.DropColumn(
                name: "ISOCode",
                table: "Cities");
        }
    }
}

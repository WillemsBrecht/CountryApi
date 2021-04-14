using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CountryApi.Migrations
{
    public partial class Addedcityseedingnetherlandsandgermany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("9ec01e17-c44a-432b-9d32-c2e0ac92299a"));

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CountryISOCode", "Name", "Population" },
                values: new object[,]
                {
                    { new Guid("ae37ddf1-85de-4ea5-92c4-0be5604e83ec"), "BE", "Bruges", 118656 },
                    { new Guid("0b51a9c0-715d-4b5b-a6e1-61b14b34e989"), "BE", "Ghent", 466000 },
                    { new Guid("8ccbfb3f-d4c4-4d08-bc20-8455ba706033"), "BE", "Antwerp", 523248 },
                    { new Guid("e8b00fb7-8b76-4823-9e37-c4ce3610670e"), "BE", "Brussels", 2081000 },
                    { new Guid("5f5af14c-0953-4e22-a58b-2ad861cdefa8"), "FR", "Paris", 11017000 },
                    { new Guid("dacffea6-df3d-42da-bee9-e0bf02909d10"), "FR", "Calais", 72929 },
                    { new Guid("3086a307-a2e1-4a0f-ab95-171f042d8db3"), "FR", "Calais", 868277 },
                    { new Guid("3b6f0870-9eec-46c9-9226-8d125f1e20a0"), "FR", "Bordeaux", 257068 },
                    { new Guid("3e6226b3-1c85-46f3-ad2d-65e87c0530f4"), "NL", "Rotterdam", 651446 },
                    { new Guid("6cfedeb1-7072-49f8-8fec-9269b00ff3a7"), "NL", "Amsterdam", 1149000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("0b51a9c0-715d-4b5b-a6e1-61b14b34e989"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("3086a307-a2e1-4a0f-ab95-171f042d8db3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("3b6f0870-9eec-46c9-9226-8d125f1e20a0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("3e6226b3-1c85-46f3-ad2d-65e87c0530f4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("5f5af14c-0953-4e22-a58b-2ad861cdefa8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("6cfedeb1-7072-49f8-8fec-9269b00ff3a7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("8ccbfb3f-d4c4-4d08-bc20-8455ba706033"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("ae37ddf1-85de-4ea5-92c4-0be5604e83ec"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("dacffea6-df3d-42da-bee9-e0bf02909d10"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("e8b00fb7-8b76-4823-9e37-c4ce3610670e"));

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CountryISOCode", "Name", "Population" },
                values: new object[] { new Guid("9ec01e17-c44a-432b-9d32-c2e0ac92299a"), "BE", "Bruges", 0 });
        }
    }
}

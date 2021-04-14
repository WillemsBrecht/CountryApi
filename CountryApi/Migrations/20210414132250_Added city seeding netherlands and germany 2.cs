using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CountryApi.Migrations
{
    public partial class Addedcityseedingnetherlandsandgermany2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { new Guid("916128d2-60f3-4838-8fe2-d1ffe968860c"), "BE", "Bruges", 118656 },
                    { new Guid("c4a5237b-c54a-453c-a078-2f2a1d37c270"), "BE", "Ghent", 466000 },
                    { new Guid("b1869b05-4632-42ee-899c-57bdb3f35a54"), "BE", "Antwerp", 523248 },
                    { new Guid("56b1f960-a27e-4a74-8645-a413e6e45403"), "BE", "Brussels", 2081000 },
                    { new Guid("e31f2928-4bd9-4bce-a3ed-01ceebceaa45"), "FR", "Paris", 11017000 },
                    { new Guid("b9490187-b242-4688-813e-fcfeb338a2d7"), "FR", "Calais", 72929 },
                    { new Guid("700c8c5c-d3e2-4fb6-9e7b-1a5f30bcb937"), "FR", "Calais", 868277 },
                    { new Guid("1acddf55-b325-411e-8aeb-ef65d7001de9"), "FR", "Bordeaux", 257068 },
                    { new Guid("8cc263ef-c8d7-4f2f-a12c-4d0ec244ff67"), "NL", "Rotterdam", 651446 },
                    { new Guid("1db99af4-f2a2-4bd0-997c-bb74a27faf58"), "NL", "Amsterdam", 1149000 },
                    { new Guid("a7069d8f-51da-4b93-81bf-eb41870d6cde"), "DE", "Berlin", 3562000 },
                    { new Guid("dbf47813-6e85-4d69-bbf6-4922bf42cbac"), "DE", "Frankfurt", 777000 },
                    { new Guid("5cd2deba-9002-4926-91ab-9cda7a4c2b4d"), "DE", "Hamburg", 1790000 },
                    { new Guid("8364584e-a6f9-4d3d-b51c-399e945c9708"), "DE", "Munich", 1558395 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("1acddf55-b325-411e-8aeb-ef65d7001de9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("1db99af4-f2a2-4bd0-997c-bb74a27faf58"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("56b1f960-a27e-4a74-8645-a413e6e45403"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("5cd2deba-9002-4926-91ab-9cda7a4c2b4d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("700c8c5c-d3e2-4fb6-9e7b-1a5f30bcb937"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("8364584e-a6f9-4d3d-b51c-399e945c9708"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("8cc263ef-c8d7-4f2f-a12c-4d0ec244ff67"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("916128d2-60f3-4838-8fe2-d1ffe968860c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("a7069d8f-51da-4b93-81bf-eb41870d6cde"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("b1869b05-4632-42ee-899c-57bdb3f35a54"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("b9490187-b242-4688-813e-fcfeb338a2d7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("c4a5237b-c54a-453c-a078-2f2a1d37c270"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("dbf47813-6e85-4d69-bbf6-4922bf42cbac"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("e31f2928-4bd9-4bce-a3ed-01ceebceaa45"));

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
    }
}

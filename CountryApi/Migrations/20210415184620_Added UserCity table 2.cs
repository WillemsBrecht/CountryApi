using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CountryApi.Migrations
{
    public partial class AddedUserCitytable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("28b28b96-6233-4f0c-a19b-adacb9b22342"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("3352e80a-526b-4437-9085-6c7f2e11193d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("3e53b2fa-94e5-47db-95ac-489e2cb367e7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("413c3255-5122-4ed1-8833-6ae771265333"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("46e7c825-de9b-4427-a37f-261001370fdd"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("5fcea13c-1c67-4e2d-9642-17c9cea029be"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("665115cc-b429-4946-a7d0-d37e0b8fce23"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("69e322ac-b6b0-40c0-bfc4-d91e085dbfd9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("6cf5ad79-ca0f-4e03-8572-84500cb9bf89"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("7be043a5-7c59-4ba1-ad62-23c183f9c154"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("89aaca47-e2ce-4501-aeec-a721dd7ecf2f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("9fa9bb93-003f-4d41-8791-5bca90c1dc41"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("a349ce6a-ed96-469c-bbab-e5bf2dda852e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("a4ed6caa-8573-417f-96fd-35a1c6ef77e6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("b496c2e5-ead9-4663-baa5-ad7b03f91b93"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("bc05a63d-f02b-48fb-8b7a-da0b207eba7f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("bf879fb7-495e-4dce-a366-045eb552d1fb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("dc559bc6-22f2-4f03-8573-c6a3d144b203"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("ee1e18f7-8b7d-45f5-9c17-c23aafbc79a3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("ff132038-0670-4cf3-8816-b3e774447213"));

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CountryISOCode", "Name", "Population" },
                values: new object[,]
                {
                    { new Guid("bd623c13-6f0e-4749-b24c-65cc64128e6b"), "LUX", "Luxembourg City", 114303 },
                    { new Guid("25eaffac-6d3a-497f-aef9-f4f42e358e08"), "DE", "Hamburg", 1790000 },
                    { new Guid("28ac2ada-ec13-48b6-ba07-d23c364fab45"), "DE", "Frankfurt", 777000 },
                    { new Guid("4c7783d1-c25d-4ab8-bbc8-501ad7bb0336"), "DE", "Berlin", 3562000 },
                    { new Guid("66b860f7-6bcd-41ab-98d6-79e79659cf18"), "NL", "Amsterdam", 1149000 },
                    { new Guid("8b750db7-ba7b-4c49-8d08-056c0fa9d1d9"), "NL", "Rotterdam", 651446 },
                    { new Guid("2f4509e4-00e7-4761-b2d4-c42b7e8118a3"), "FR", "Bordeaux", 257068 },
                    { new Guid("5e8e84c6-ad5d-432d-b907-d4817624a494"), "FR", "Calais", 868277 },
                    { new Guid("c6acde98-1b74-41b5-b19b-86b6b7f62dc9"), "FR", "Calais", 72929 },
                    { new Guid("77a70821-1321-4351-9aaa-46309126c039"), "FR", "Paris", 11017000 },
                    { new Guid("9127be63-e6e2-481a-897e-6e086c11f6d4"), "FR", "Strasbourg", 272222 },
                    { new Guid("dce753c4-f269-4dd3-a642-cb5bfe9d96f0"), "BE", "Tournai", 69083 },
                    { new Guid("de1f292d-2b21-448e-a0ee-af0b8ef85f97"), "BE", "Liège", 195965 },
                    { new Guid("16ff71d5-576b-4f2f-ac1f-79c6af2fa804"), "BE", "Brussels", 2081000 },
                    { new Guid("27ab75f7-cb49-484c-8bf9-b9d4c83ce8da"), "BE", "Antwerp", 523248 },
                    { new Guid("6646ab14-42e9-4cc1-8c9c-b0f9a5cba91d"), "BE", "Ghent", 466000 },
                    { new Guid("dbba6527-4ff7-4aee-acc6-be8dac6ce333"), "BE", "Bruges", 118656 },
                    { new Guid("562ba64e-50b2-488e-827c-719ce3424618"), "LUX", "Echternach", 5614 },
                    { new Guid("057dee0b-ec44-4d0f-9542-3346f10a2f8c"), "DE", "Munich", 1558395 },
                    { new Guid("d9fc3bca-9c0f-44b1-99be-0d8a5863a6ec"), "DE", "Trier", 111528 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("057dee0b-ec44-4d0f-9542-3346f10a2f8c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("16ff71d5-576b-4f2f-ac1f-79c6af2fa804"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("25eaffac-6d3a-497f-aef9-f4f42e358e08"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("27ab75f7-cb49-484c-8bf9-b9d4c83ce8da"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("28ac2ada-ec13-48b6-ba07-d23c364fab45"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("2f4509e4-00e7-4761-b2d4-c42b7e8118a3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("4c7783d1-c25d-4ab8-bbc8-501ad7bb0336"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("562ba64e-50b2-488e-827c-719ce3424618"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("5e8e84c6-ad5d-432d-b907-d4817624a494"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("6646ab14-42e9-4cc1-8c9c-b0f9a5cba91d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("66b860f7-6bcd-41ab-98d6-79e79659cf18"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("77a70821-1321-4351-9aaa-46309126c039"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("8b750db7-ba7b-4c49-8d08-056c0fa9d1d9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("9127be63-e6e2-481a-897e-6e086c11f6d4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("bd623c13-6f0e-4749-b24c-65cc64128e6b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("c6acde98-1b74-41b5-b19b-86b6b7f62dc9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("d9fc3bca-9c0f-44b1-99be-0d8a5863a6ec"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("dbba6527-4ff7-4aee-acc6-be8dac6ce333"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("dce753c4-f269-4dd3-a642-cb5bfe9d96f0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("de1f292d-2b21-448e-a0ee-af0b8ef85f97"));

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CountryISOCode", "Name", "Population" },
                values: new object[,]
                {
                    { new Guid("28b28b96-6233-4f0c-a19b-adacb9b22342"), "LUX", "Luxembourg City", 114303 },
                    { new Guid("6cf5ad79-ca0f-4e03-8572-84500cb9bf89"), "DE", "Hamburg", 1790000 },
                    { new Guid("bc05a63d-f02b-48fb-8b7a-da0b207eba7f"), "DE", "Frankfurt", 777000 },
                    { new Guid("7be043a5-7c59-4ba1-ad62-23c183f9c154"), "DE", "Berlin", 3562000 },
                    { new Guid("3e53b2fa-94e5-47db-95ac-489e2cb367e7"), "NL", "Amsterdam", 1149000 },
                    { new Guid("665115cc-b429-4946-a7d0-d37e0b8fce23"), "NL", "Rotterdam", 651446 },
                    { new Guid("dc559bc6-22f2-4f03-8573-c6a3d144b203"), "FR", "Bordeaux", 257068 },
                    { new Guid("413c3255-5122-4ed1-8833-6ae771265333"), "FR", "Calais", 868277 },
                    { new Guid("ee1e18f7-8b7d-45f5-9c17-c23aafbc79a3"), "FR", "Calais", 72929 },
                    { new Guid("9fa9bb93-003f-4d41-8791-5bca90c1dc41"), "FR", "Paris", 11017000 },
                    { new Guid("bf879fb7-495e-4dce-a366-045eb552d1fb"), "FR", "Strasbourg", 272222 },
                    { new Guid("a4ed6caa-8573-417f-96fd-35a1c6ef77e6"), "BE", "Tournai", 69083 },
                    { new Guid("46e7c825-de9b-4427-a37f-261001370fdd"), "BE", "Liège", 195965 },
                    { new Guid("a349ce6a-ed96-469c-bbab-e5bf2dda852e"), "BE", "Brussels", 2081000 },
                    { new Guid("89aaca47-e2ce-4501-aeec-a721dd7ecf2f"), "BE", "Antwerp", 523248 },
                    { new Guid("3352e80a-526b-4437-9085-6c7f2e11193d"), "BE", "Ghent", 466000 },
                    { new Guid("b496c2e5-ead9-4663-baa5-ad7b03f91b93"), "BE", "Bruges", 118656 },
                    { new Guid("69e322ac-b6b0-40c0-bfc4-d91e085dbfd9"), "LUX", "Echternach", 5614 },
                    { new Guid("5fcea13c-1c67-4e2d-9642-17c9cea029be"), "DE", "Munich", 1558395 },
                    { new Guid("ff132038-0670-4cf3-8816-b3e774447213"), "DE", "Trier", 111528 }
                });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CountryApi.Migrations
{
    public partial class AddedUserCitytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("0ff39296-d6f9-47f4-880f-a24d881bf6e0"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("212a1825-3274-451b-912b-0820b621cb1b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("2ed4f14b-b22b-41f0-bfb5-66f2ebb2fe51"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("4eb101b3-368e-45bc-87bf-431e788f1a06"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("5274a5d1-750f-425d-b4e8-ea729ef8d26b"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("59588509-0bf6-4ecf-8a6e-da654c18c195"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("5d6f107d-7eea-4d88-a276-a86b1d27f996"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("5e770831-9666-4aac-9236-6f5dd3c9ac52"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("61bb07ff-b254-443f-a756-16fa4743756d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("6358e80b-6b29-4c70-9f9c-4824a4c0e930"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("6b319435-7dce-4570-b750-b4155fb7668c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("72c4d020-bbca-43b6-bab7-7adfa0872d1d"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("72f0974f-eedc-412c-bfc2-d73533cfeb9f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("76376c89-bc31-4969-b9fc-aa8748cf88e9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("8c615d16-7f7c-4930-87a7-f7dd5a7147eb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("909c2ada-fb4f-474c-9a3b-da29f3181451"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("b9ec61a4-ad94-4638-8f38-57880381fcfb"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("ca2db91e-5faa-497a-842d-c1036100b446"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("d36477f1-bf29-4ffc-8311-6bfda69f5713"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("ee085812-b199-4310-aa69-7023aac2974e"));

            migrationBuilder.CreateTable(
                name: "UserCities",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCities", x => new { x.UserId, x.CityId });
                    table.ForeignKey(
                        name: "FK_UserCities_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserCities");

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
                    { new Guid("72c4d020-bbca-43b6-bab7-7adfa0872d1d"), "LUX", "Luxembourg City", 114303 },
                    { new Guid("61bb07ff-b254-443f-a756-16fa4743756d"), "DE", "Hamburg", 1790000 },
                    { new Guid("212a1825-3274-451b-912b-0820b621cb1b"), "DE", "Frankfurt", 777000 },
                    { new Guid("5e770831-9666-4aac-9236-6f5dd3c9ac52"), "DE", "Berlin", 3562000 },
                    { new Guid("0ff39296-d6f9-47f4-880f-a24d881bf6e0"), "NL", "Amsterdam", 1149000 },
                    { new Guid("4eb101b3-368e-45bc-87bf-431e788f1a06"), "NL", "Rotterdam", 651446 },
                    { new Guid("72f0974f-eedc-412c-bfc2-d73533cfeb9f"), "FR", "Bordeaux", 257068 },
                    { new Guid("ca2db91e-5faa-497a-842d-c1036100b446"), "FR", "Calais", 868277 },
                    { new Guid("8c615d16-7f7c-4930-87a7-f7dd5a7147eb"), "FR", "Calais", 72929 },
                    { new Guid("6b319435-7dce-4570-b750-b4155fb7668c"), "FR", "Paris", 11017000 },
                    { new Guid("76376c89-bc31-4969-b9fc-aa8748cf88e9"), "FR", "Strasbourg", 272222 },
                    { new Guid("ee085812-b199-4310-aa69-7023aac2974e"), "BE", "Tournai", 69083 },
                    { new Guid("2ed4f14b-b22b-41f0-bfb5-66f2ebb2fe51"), "BE", "Liège", 195965 },
                    { new Guid("5274a5d1-750f-425d-b4e8-ea729ef8d26b"), "BE", "Brussels", 2081000 },
                    { new Guid("59588509-0bf6-4ecf-8a6e-da654c18c195"), "BE", "Antwerp", 523248 },
                    { new Guid("6358e80b-6b29-4c70-9f9c-4824a4c0e930"), "BE", "Ghent", 466000 },
                    { new Guid("d36477f1-bf29-4ffc-8311-6bfda69f5713"), "BE", "Bruges", 118656 },
                    { new Guid("909c2ada-fb4f-474c-9a3b-da29f3181451"), "LUX", "Echternach", 5614 },
                    { new Guid("b9ec61a4-ad94-4638-8f38-57880381fcfb"), "DE", "Munich", 1558395 },
                    { new Guid("5d6f107d-7eea-4d88-a276-a86b1d27f996"), "DE", "Trier", 111528 }
                });
        }
    }
}

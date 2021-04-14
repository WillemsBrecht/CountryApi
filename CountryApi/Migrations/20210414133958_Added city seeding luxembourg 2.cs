using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CountryApi.Migrations
{
    public partial class Addedcityseedingluxembourg2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("19fccb75-1992-42ae-8452-248d88912816"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("2e892457-0a44-4073-805f-0c5cef4f350c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("31917678-b45f-47a9-b1f5-f5c2c39f9c34"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("53fe7244-6551-4818-85ba-d1c7902b8987"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("59fe91ac-bbe3-40f9-a609-6207e2f1eda9"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("6780f893-b060-4194-a8d7-36263bc3aff7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("79d8efe3-ee84-42d3-9e02-e0427af35067"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("7f17de0e-2f1c-4709-bf71-2550c620acb5"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("7febfeea-f047-46d7-9da3-8017316b93d3"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("854dd92b-e201-4d1f-818e-ddaa1ace0156"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("95baa16b-e500-4aca-a6b6-20204edf1d95"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("aae61697-de79-4971-840f-57984c552bab"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("ab6428d8-9d4d-46fd-a7ad-774a5ef4c578"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("bded7796-091e-4e18-b158-c3e1abdbe500"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("d59dc02c-09e1-467b-a327-8b45d462670a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("e51412e7-9320-4101-a178-aa37d6e730f4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("ebde4970-6c1d-4d21-a264-d0d946347daa"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("f0f165dd-4c8e-4d93-83ff-19f4126edeb7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("fbb521fe-e8f1-4689-ade6-539a92b9d9e7"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CountryISOCode", "Name", "Population" },
                values: new object[,]
                {
                    { new Guid("6780f893-b060-4194-a8d7-36263bc3aff7"), "LUX", "Luxembourg City", 114303 },
                    { new Guid("aae61697-de79-4971-840f-57984c552bab"), "DE", "Hamburg", 1790000 },
                    { new Guid("d59dc02c-09e1-467b-a327-8b45d462670a"), "DE", "Frankfurt", 777000 },
                    { new Guid("7f17de0e-2f1c-4709-bf71-2550c620acb5"), "DE", "Berlin", 3562000 },
                    { new Guid("95baa16b-e500-4aca-a6b6-20204edf1d95"), "NL", "Amsterdam", 1149000 },
                    { new Guid("53fe7244-6551-4818-85ba-d1c7902b8987"), "NL", "Rotterdam", 651446 },
                    { new Guid("ab6428d8-9d4d-46fd-a7ad-774a5ef4c578"), "FR", "Bordeaux", 257068 },
                    { new Guid("59fe91ac-bbe3-40f9-a609-6207e2f1eda9"), "FR", "Calais", 868277 },
                    { new Guid("ebde4970-6c1d-4d21-a264-d0d946347daa"), "DE", "Munich", 1558395 },
                    { new Guid("854dd92b-e201-4d1f-818e-ddaa1ace0156"), "FR", "Calais", 72929 },
                    { new Guid("79d8efe3-ee84-42d3-9e02-e0427af35067"), "BE", "Tournai", 69083 },
                    { new Guid("e51412e7-9320-4101-a178-aa37d6e730f4"), "BE", "Liège", 195965 },
                    { new Guid("19fccb75-1992-42ae-8452-248d88912816"), "BE", "Brussels", 2081000 },
                    { new Guid("fbb521fe-e8f1-4689-ade6-539a92b9d9e7"), "BE", "Antwerp", 523248 },
                    { new Guid("31917678-b45f-47a9-b1f5-f5c2c39f9c34"), "BE", "Ghent", 466000 },
                    { new Guid("7febfeea-f047-46d7-9da3-8017316b93d3"), "BE", "Bruges", 118656 },
                    { new Guid("f0f165dd-4c8e-4d93-83ff-19f4126edeb7"), "LUX", "Echternach", 5614 },
                    { new Guid("bded7796-091e-4e18-b158-c3e1abdbe500"), "FR", "Paris", 11017000 },
                    { new Guid("2e892457-0a44-4073-805f-0c5cef4f350c"), "DE", "Trier", 111528 }
                });
        }
    }
}

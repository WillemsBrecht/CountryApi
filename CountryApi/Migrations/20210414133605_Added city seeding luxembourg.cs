using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CountryApi.Migrations
{
    public partial class Addedcityseedingluxembourg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("7febfeea-f047-46d7-9da3-8017316b93d3"), "BE", "Bruges", 118656 },
                    { new Guid("2e892457-0a44-4073-805f-0c5cef4f350c"), "DE", "Trier", 111528 },
                    { new Guid("ebde4970-6c1d-4d21-a264-d0d946347daa"), "DE", "Munich", 1558395 },
                    { new Guid("aae61697-de79-4971-840f-57984c552bab"), "DE", "Hamburg", 1790000 },
                    { new Guid("d59dc02c-09e1-467b-a327-8b45d462670a"), "DE", "Frankfurt", 777000 },
                    { new Guid("7f17de0e-2f1c-4709-bf71-2550c620acb5"), "DE", "Berlin", 3562000 },
                    { new Guid("95baa16b-e500-4aca-a6b6-20204edf1d95"), "NL", "Amsterdam", 1149000 },
                    { new Guid("53fe7244-6551-4818-85ba-d1c7902b8987"), "NL", "Rotterdam", 651446 },
                    { new Guid("ab6428d8-9d4d-46fd-a7ad-774a5ef4c578"), "FR", "Bordeaux", 257068 },
                    { new Guid("854dd92b-e201-4d1f-818e-ddaa1ace0156"), "FR", "Calais", 72929 },
                    { new Guid("bded7796-091e-4e18-b158-c3e1abdbe500"), "FR", "Paris", 11017000 },
                    { new Guid("79d8efe3-ee84-42d3-9e02-e0427af35067"), "BE", "Tournai", 69083 },
                    { new Guid("e51412e7-9320-4101-a178-aa37d6e730f4"), "BE", "Liège", 195965 },
                    { new Guid("19fccb75-1992-42ae-8452-248d88912816"), "BE", "Brussels", 2081000 },
                    { new Guid("fbb521fe-e8f1-4689-ade6-539a92b9d9e7"), "BE", "Antwerp", 523248 },
                    { new Guid("31917678-b45f-47a9-b1f5-f5c2c39f9c34"), "BE", "Ghent", 466000 },
                    { new Guid("59fe91ac-bbe3-40f9-a609-6207e2f1eda9"), "FR", "Calais", 868277 }
                });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ISOCode",
                keyValue: "NL",
                column: "Name",
                value: "The Netherlands");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ISOCode", "Name", "Population" },
                values: new object[] { "LUX", "Luxembourg", 613894 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CountryISOCode", "Name", "Population" },
                values: new object[] { new Guid("6780f893-b060-4194-a8d7-36263bc3aff7"), "LUX", "Luxembourg City", 114303 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CountryISOCode", "Name", "Population" },
                values: new object[] { new Guid("f0f165dd-4c8e-4d93-83ff-19f4126edeb7"), "LUX", "Echternach", 5614 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "ISOCode",
                keyValue: "LUX");

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

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ISOCode",
                keyValue: "NL",
                column: "Name",
                value: "Netherlands");
        }
    }
}

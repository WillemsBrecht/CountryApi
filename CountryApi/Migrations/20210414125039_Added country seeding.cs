using Microsoft.EntityFrameworkCore.Migrations;

namespace CountryApi.Migrations
{
    public partial class Addedcountryseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ISOCode",
                keyValue: "BE",
                column: "Population",
                value: 11629113);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ISOCode",
                keyValue: "DE",
                column: "Population",
                value: 83995211);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ISOCode",
                keyValue: "FR",
                column: "Population",
                value: 65387226);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ISOCode",
                keyValue: "NL",
                column: "Population",
                value: 17164721);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ISOCode",
                keyValue: "BE",
                column: "Population",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ISOCode",
                keyValue: "DE",
                column: "Population",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ISOCode",
                keyValue: "FR",
                column: "Population",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "ISOCode",
                keyValue: "NL",
                column: "Population",
                value: 0);
        }
    }
}

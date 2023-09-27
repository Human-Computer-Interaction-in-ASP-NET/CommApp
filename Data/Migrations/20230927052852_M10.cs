using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CommunityApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class M10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceCode",
                keyValue: "101");

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceCode",
                keyValue: "102");

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceCode",
                keyValue: "103");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                column: "ProvinceCode",
                value: "BC");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 2,
                column: "ProvinceCode",
                value: "BC");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 3,
                column: "ProvinceCode",
                value: "BC");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 4,
                column: "ProvinceCode",
                value: "ONT");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 5,
                column: "ProvinceCode",
                value: "ONT");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 6,
                column: "ProvinceCode",
                value: "ONT");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 7,
                column: "ProvinceCode",
                value: "ALB");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 8,
                column: "ProvinceCode",
                value: "ALB");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 9,
                column: "ProvinceCode",
                value: "ALB");

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[,]
                {
                    { "ALB", "AL" },
                    { "BC", "BC" },
                    { "ONT", "ONT" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceCode",
                keyValue: "ALB");

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceCode",
                keyValue: "BC");

            migrationBuilder.DeleteData(
                table: "Province",
                keyColumn: "ProvinceCode",
                keyValue: "ONT");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                column: "ProvinceCode",
                value: "101");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 2,
                column: "ProvinceCode",
                value: "101");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 3,
                column: "ProvinceCode",
                value: "101");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 4,
                column: "ProvinceCode",
                value: "102");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 5,
                column: "ProvinceCode",
                value: "102");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 6,
                column: "ProvinceCode",
                value: "102");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 7,
                column: "ProvinceCode",
                value: "103");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 8,
                column: "ProvinceCode",
                value: "103");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 9,
                column: "ProvinceCode",
                value: "103");

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[,]
                {
                    { "101", "BC" },
                    { "102", "ONT" },
                    { "103", "AL" }
                });
        }
    }
}

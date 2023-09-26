using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommunityApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class M3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Province_ProvinceCode1",
                table: "City");

            migrationBuilder.DropIndex(
                name: "IX_City_ProvinceCode1",
                table: "City");

            migrationBuilder.DropColumn(
                name: "ProvinceCode1",
                table: "City");

            migrationBuilder.AlterColumn<string>(
                name: "ProvinceCode",
                table: "City",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_City_ProvinceCode",
                table: "City",
                column: "ProvinceCode");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Province_ProvinceCode",
                table: "City",
                column: "ProvinceCode",
                principalTable: "Province",
                principalColumn: "ProvinceCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Province_ProvinceCode",
                table: "City");

            migrationBuilder.DropIndex(
                name: "IX_City_ProvinceCode",
                table: "City");

            migrationBuilder.AlterColumn<string>(
                name: "ProvinceCode",
                table: "City",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProvinceCode1",
                table: "City",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 1,
                column: "ProvinceCode1",
                value: null);

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 2,
                column: "ProvinceCode1",
                value: null);

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 3,
                column: "ProvinceCode1",
                value: null);

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 4,
                column: "ProvinceCode1",
                value: null);

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 5,
                column: "ProvinceCode1",
                value: null);

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 6,
                column: "ProvinceCode1",
                value: null);

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 7,
                column: "ProvinceCode1",
                value: null);

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 8,
                column: "ProvinceCode1",
                value: null);

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "CityId",
                keyValue: 9,
                column: "ProvinceCode1",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_City_ProvinceCode1",
                table: "City",
                column: "ProvinceCode1");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Province_ProvinceCode1",
                table: "City",
                column: "ProvinceCode1",
                principalTable: "Province",
                principalColumn: "ProvinceCode");
        }
    }
}

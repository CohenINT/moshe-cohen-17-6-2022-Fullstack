using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherApi.Migrations
{
    public partial class frtMIG : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LocationKey",
                table: "WeatherRecords",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationKey",
                table: "WeatherRecords");
        }
    }
}

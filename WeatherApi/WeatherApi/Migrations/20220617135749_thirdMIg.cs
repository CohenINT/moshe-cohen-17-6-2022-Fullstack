using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherApi.Migrations
{
    public partial class thirdMIg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DirectionModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Degrees = table.Column<int>(type: "int", nullable: false),
                    English = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Localized = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectionModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImperialModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImperialModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LocalSourceModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeatherCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalSourceModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MetricModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<double>(type: "float", nullable: false),
                    UnitType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetricModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PressureTendencyModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LocalizedText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PressureTendencyModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WindGustModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Speed = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WindGustModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WindModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DirectionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Speed = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WindModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WindModel_DirectionModel_DirectionId",
                        column: x => x.DirectionId,
                        principalTable: "DirectionModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TemperatureModel",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ImperialId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MetricId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemperatureModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TemperatureModel_ImperialModel_ImperialId",
                        column: x => x.ImperialId,
                        principalTable: "ImperialModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TemperatureModel_MetricModel_MetricId",
                        column: x => x.MetricId,
                        principalTable: "MetricModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WeatherRecords",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LocalObservationDateTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EpochTime = table.Column<long>(type: "bigint", nullable: false),
                    WeatherText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WeatherIcon = table.Column<int>(type: "int", nullable: false),
                    LocalSourceId = table.Column<int>(type: "int", nullable: true),
                    IsDayTime = table.Column<bool>(type: "bit", nullable: false),
                    TemperatureId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    RealFeelTemperature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RealFeelTemperatureShade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelativeHumidity = table.Column<int>(type: "int", nullable: false),
                    DewPoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WindId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    WindGustId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UVIndex = table.Column<int>(type: "int", nullable: false),
                    UVIndexText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Visibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObstructionsToVisibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CloudCover = table.Column<int>(type: "int", nullable: false),
                    Ceiling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pressure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PressureTendencyId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Past24HourTemperatureDeparture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApparentTemperature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WindChillTemperature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WetBulbTemperature = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeatherRecords_LocalSourceModel_LocalSourceId",
                        column: x => x.LocalSourceId,
                        principalTable: "LocalSourceModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WeatherRecords_PressureTendencyModel_PressureTendencyId",
                        column: x => x.PressureTendencyId,
                        principalTable: "PressureTendencyModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WeatherRecords_TemperatureModel_TemperatureId",
                        column: x => x.TemperatureId,
                        principalTable: "TemperatureModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WeatherRecords_WindGustModel_WindGustId",
                        column: x => x.WindGustId,
                        principalTable: "WindGustModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WeatherRecords_WindModel_WindId",
                        column: x => x.WindId,
                        principalTable: "WindModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TemperatureModel_ImperialId",
                table: "TemperatureModel",
                column: "ImperialId");

            migrationBuilder.CreateIndex(
                name: "IX_TemperatureModel_MetricId",
                table: "TemperatureModel",
                column: "MetricId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherRecords_LocalSourceId",
                table: "WeatherRecords",
                column: "LocalSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherRecords_PressureTendencyId",
                table: "WeatherRecords",
                column: "PressureTendencyId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherRecords_TemperatureId",
                table: "WeatherRecords",
                column: "TemperatureId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherRecords_WindGustId",
                table: "WeatherRecords",
                column: "WindGustId");

            migrationBuilder.CreateIndex(
                name: "IX_WeatherRecords_WindId",
                table: "WeatherRecords",
                column: "WindId");

            migrationBuilder.CreateIndex(
                name: "IX_WindModel_DirectionId",
                table: "WindModel",
                column: "DirectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherRecords");

            migrationBuilder.DropTable(
                name: "LocalSourceModel");

            migrationBuilder.DropTable(
                name: "PressureTendencyModel");

            migrationBuilder.DropTable(
                name: "TemperatureModel");

            migrationBuilder.DropTable(
                name: "WindGustModel");

            migrationBuilder.DropTable(
                name: "WindModel");

            migrationBuilder.DropTable(
                name: "ImperialModel");

            migrationBuilder.DropTable(
                name: "MetricModel");

            migrationBuilder.DropTable(
                name: "DirectionModel");
        }
    }
}

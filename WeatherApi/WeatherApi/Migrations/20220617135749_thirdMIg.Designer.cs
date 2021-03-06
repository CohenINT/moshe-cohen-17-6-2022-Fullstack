// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WeatherApi.Models;

namespace WeatherApi.Migrations
{
    [DbContext(typeof(WeatherDbContext))]
    [Migration("20220617135749_thirdMIg")]
    partial class thirdMIg
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WeatherApi.Models.DirectionModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Degrees")
                        .HasColumnType("int");

                    b.Property<string>("English")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localized")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DirectionModel");
                });

            modelBuilder.Entity("WeatherApi.Models.ImperialModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnitType")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("ImperialModel");
                });

            modelBuilder.Entity("WeatherApi.Models.LocalSourceModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeatherCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LocalSourceModel");
                });

            modelBuilder.Entity("WeatherApi.Models.MetricModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnitType")
                        .HasColumnType("int");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("MetricModel");
                });

            modelBuilder.Entity("WeatherApi.Models.PressureTendencyModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalizedText")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PressureTendencyModel");
                });

            modelBuilder.Entity("WeatherApi.Models.TemperatureModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ImperialId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MetricId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ImperialId");

                    b.HasIndex("MetricId");

                    b.ToTable("TemperatureModel");
                });

            modelBuilder.Entity("WeatherApi.Models.WeatherConditions", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApparentTemperature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ceiling")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CloudCover")
                        .HasColumnType("int");

                    b.Property<string>("DewPoint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("EpochTime")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDayTime")
                        .HasColumnType("bit");

                    b.Property<string>("LocalObservationDateTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LocalSourceId")
                        .HasColumnType("int");

                    b.Property<string>("ObstructionsToVisibility")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Past24HourTemperatureDeparture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pressure")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PressureTendencyId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RealFeelTemperature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RealFeelTemperatureShade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RelativeHumidity")
                        .HasColumnType("int");

                    b.Property<string>("TemperatureId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("UVIndex")
                        .HasColumnType("int");

                    b.Property<string>("UVIndexText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Visibility")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WeatherIcon")
                        .HasColumnType("int");

                    b.Property<string>("WeatherText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WetBulbTemperature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WindChillTemperature")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WindGustId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("WindId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("LocalSourceId");

                    b.HasIndex("PressureTendencyId");

                    b.HasIndex("TemperatureId");

                    b.HasIndex("WindGustId");

                    b.HasIndex("WindId");

                    b.ToTable("WeatherRecords");
                });

            modelBuilder.Entity("WeatherApi.Models.WindGustModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Speed")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WindGustModel");
                });

            modelBuilder.Entity("WeatherApi.Models.WindModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DirectionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Speed")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DirectionId");

                    b.ToTable("WindModel");
                });

            modelBuilder.Entity("WeatherApi.Models.TemperatureModel", b =>
                {
                    b.HasOne("WeatherApi.Models.ImperialModel", "Imperial")
                        .WithMany()
                        .HasForeignKey("ImperialId");

                    b.HasOne("WeatherApi.Models.MetricModel", "Metric")
                        .WithMany()
                        .HasForeignKey("MetricId");

                    b.Navigation("Imperial");

                    b.Navigation("Metric");
                });

            modelBuilder.Entity("WeatherApi.Models.WeatherConditions", b =>
                {
                    b.HasOne("WeatherApi.Models.LocalSourceModel", "LocalSource")
                        .WithMany()
                        .HasForeignKey("LocalSourceId");

                    b.HasOne("WeatherApi.Models.PressureTendencyModel", "PressureTendency")
                        .WithMany()
                        .HasForeignKey("PressureTendencyId");

                    b.HasOne("WeatherApi.Models.TemperatureModel", "Temperature")
                        .WithMany()
                        .HasForeignKey("TemperatureId");

                    b.HasOne("WeatherApi.Models.WindGustModel", "WindGust")
                        .WithMany()
                        .HasForeignKey("WindGustId");

                    b.HasOne("WeatherApi.Models.WindModel", "Wind")
                        .WithMany()
                        .HasForeignKey("WindId");

                    b.Navigation("LocalSource");

                    b.Navigation("PressureTendency");

                    b.Navigation("Temperature");

                    b.Navigation("Wind");

                    b.Navigation("WindGust");
                });

            modelBuilder.Entity("WeatherApi.Models.WindModel", b =>
                {
                    b.HasOne("WeatherApi.Models.DirectionModel", "Direction")
                        .WithMany()
                        .HasForeignKey("DirectionId");

                    b.Navigation("Direction");
                });
#pragma warning restore 612, 618
        }
    }
}

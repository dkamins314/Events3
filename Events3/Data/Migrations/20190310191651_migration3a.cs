using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Events3.Data.Migrations
{
    public partial class migration3a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreateYearlyEventsViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StartingDate = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<string>(nullable: true),
                    EndingDate = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<string>(nullable: true),
                    SpecialEvents = table.Column<int>(nullable: false),
                    SpecialShabassos = table.Column<int>(nullable: false),
                    Months = table.Column<int>(nullable: false),
                    Parshios = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreateYearlyEventsViewModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YearlyEvents_1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StartingDate = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<string>(nullable: true),
                    EndingDate = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<string>(nullable: true),
                    SpecialEvents = table.Column<int>(nullable: false),
                    SpecialShabassos = table.Column<int>(nullable: false),
                    Months = table.Column<int>(nullable: false),
                    Parshios = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearlyEvents_1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YearlyEventsViewModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StartingDate = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<string>(nullable: true),
                    EndingDate = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<string>(nullable: true),
                    SpecialEvents = table.Column<int>(nullable: false),
                    SpecialShabassos = table.Column<int>(nullable: false),
                    Months = table.Column<int>(nullable: false),
                    Parshios = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YearlyEventsViewModel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreateYearlyEventsViewModel");

            migrationBuilder.DropTable(
                name: "YearlyEvents_1");

            migrationBuilder.DropTable(
                name: "YearlyEventsViewModel");
        }
    }
}

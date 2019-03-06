using Microsoft.EntityFrameworkCore.Migrations;

namespace Events3.Data.Migrations
{
    public partial class migration9a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EndTime",
                table: "YearlyEventsViewModel",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Months",
                table: "YearlyEventsViewModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Parshios",
                table: "YearlyEventsViewModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpecialEvents",
                table: "YearlyEventsViewModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpecialShabassos",
                table: "YearlyEventsViewModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StartTime",
                table: "YearlyEventsViewModel",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "YearlyEventsViewModel");

            migrationBuilder.DropColumn(
                name: "Months",
                table: "YearlyEventsViewModel");

            migrationBuilder.DropColumn(
                name: "Parshios",
                table: "YearlyEventsViewModel");

            migrationBuilder.DropColumn(
                name: "SpecialEvents",
                table: "YearlyEventsViewModel");

            migrationBuilder.DropColumn(
                name: "SpecialShabassos",
                table: "YearlyEventsViewModel");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "YearlyEventsViewModel");
        }
    }
}

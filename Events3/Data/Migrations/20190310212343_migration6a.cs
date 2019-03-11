using Microsoft.EntityFrameworkCore.Migrations;

namespace Events3.Data.Migrations
{
    public partial class migration6a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EventDescription",
                table: "YearlyEvents_1",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EventDescription",
                table: "CreateYearlyEventsViewModel",
                maxLength: 1000,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventDescription",
                table: "YearlyEvents_1");

            migrationBuilder.DropColumn(
                name: "EventDescription",
                table: "CreateYearlyEventsViewModel");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Events3.Data.Migrations
{
    public partial class migration5a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LifeEvents",
                table: "YearlyEvents_1",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LifeEvents",
                table: "CreateYearlyEventsViewModel",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LifeEvents",
                table: "YearlyEvents_1");

            migrationBuilder.DropColumn(
                name: "LifeEvents",
                table: "CreateYearlyEventsViewModel");
        }
    }
}

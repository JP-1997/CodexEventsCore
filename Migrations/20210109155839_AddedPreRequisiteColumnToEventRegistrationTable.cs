using Microsoft.EntityFrameworkCore.Migrations;

namespace CodexEvents.Migrations
{
    public partial class AddedPreRequisiteColumnToEventRegistrationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PreRequisite",
                table: "EventRegistrations",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PreRequisite",
                table: "EventRegistrations");
        }
    }
}

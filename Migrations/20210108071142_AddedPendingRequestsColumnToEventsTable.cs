using Microsoft.EntityFrameworkCore.Migrations;

namespace CodexEvents.Migrations
{
    public partial class AddedPendingRequestsColumnToEventsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PendingRequests",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PendingRequests",
                table: "Events");
        }
    }
}

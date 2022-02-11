using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Web.Migrations
{
    public partial class updateLeaveTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "LeaveTypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "LeaveAllocations",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "LeaveTypes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "LeaveTypes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LeaveTypes",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LeaveAllocations",
                newName: "id");
        }
    }
}

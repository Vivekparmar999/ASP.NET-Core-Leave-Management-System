using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Web.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67aa2cf7-7951-4ffe-b1f0-76f8705e6461",
                column: "ConcurrencyStamp",
                value: "fb04635f-0d20-4670-9c94-722fdcabb9fd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67cb2cf7-7950-4ffe-b1f0-75f8705e6461",
                column: "ConcurrencyStamp",
                value: "d30f4382-b05f-41da-be23-a1a52c9f4506");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67bi2cf3-2950-4ffe-b1f0-75f8705e2469",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5cb1f27-0a4f-4cf2-ad9a-c10a3a4507ea", "AQAAAAEAACcQAAAAELCGrrLUkNCxt5lSEHmanCFLZyCefnF277omhZyMRruhw8z5to9Yycb7QvCPTY1VrA==", "f8e3d1d0-8b4b-4627-a76a-2d9ba520b577" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67bq2cb3-1955-4sfe-b1f7-73f8705e2469",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f461f74e-5f46-4939-a6ff-e3fbfc0c1ef2", "AQAAAAEAACcQAAAAECSbhJtOfRu9s5YTIJKDpz/tC7QnLTYKhzS8kPxZPcdeT6EB1VwE1YbmrQQBNfpS/A==", "8c156caf-447b-4036-9dca-591e8095fb3c" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67aa2cf7-7951-4ffe-b1f0-76f8705e6461",
                column: "ConcurrencyStamp",
                value: "e22cf2ea-d814-46c9-9666-314fa99e0c1e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67cb2cf7-7950-4ffe-b1f0-75f8705e6461",
                column: "ConcurrencyStamp",
                value: "f3584638-feb6-4444-82a8-ef2226147b00");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67bi2cf3-2950-4ffe-b1f0-75f8705e2469",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0faeaf5d-7c14-46ac-8b12-7208d9ed8c52", "AQAAAAEAACcQAAAAEAeqn93IRT/rtEBBmYsfa8G/e6Um+9/EOtNb4z5bpC7PWK8v79cS/AKbNiEqwYhELg==", "7a554114-96a3-4c69-b0c2-c323e7b6e126" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67bq2cb3-1955-4sfe-b1f7-73f8705e2469",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac84e47d-327b-4008-9ad2-44d19188fb4f", "AQAAAAEAACcQAAAAEBtbYxG6TRHVrYI87Vc4K7B1fsKjQPPBrx6CzsB9m+fYM2qRZgruk1T0YyJi1cZ3FA==", "dc1cf9e1-9816-44c2-af96-e11e8c6ce8ec" });
        }
    }
}

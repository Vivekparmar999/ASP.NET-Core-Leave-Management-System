using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Web.Migrations
{
    public partial class AddedNumberOfDaysInLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfDays",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfDays",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67aa2cf7-7951-4ffe-b1f0-76f8705e6461",
                column: "ConcurrencyStamp",
                value: "6392269d-f0b7-40d7-ab7f-7535094e6c7c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67cb2cf7-7950-4ffe-b1f0-75f8705e6461",
                column: "ConcurrencyStamp",
                value: "0736b331-72df-43f5-8f3d-3af6cd50e6c6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67bi2cf3-2950-4ffe-b1f0-75f8705e2469",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dc59fcd-5b77-4b64-96fb-a1c6644fa091", "AQAAAAEAACcQAAAAEJVHuOrnIt3B8/iUb4qPHqXNOss5yw/ETOSZoQONpqvAZPZ9tg0KWfDwvRmumhOvSw==", "45a04781-d845-4211-863f-6ba89ee6b3b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67bq2cb3-1955-4sfe-b1f7-73f8705e2469",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "109af46a-a428-4b60-bbb1-4b5f7ce003ff", "AQAAAAEAACcQAAAAEKku6ivzVNa4bZ3kvhxzEtCqniWiQO77nrnAz/B7ieXA9qK1YBHwAKwS3bvVB1bNXQ==", "83de1b91-ed29-40c7-945f-9a9b4be55818" });
        }
    }
}

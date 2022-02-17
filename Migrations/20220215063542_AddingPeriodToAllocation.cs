using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Web.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67aa2cf7-7951-4ffe-b1f0-76f8705e6461",
                column: "ConcurrencyStamp",
                value: "fc2a6d1b-a12a-4f70-9d0c-388cbe877582");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67cb2cf7-7950-4ffe-b1f0-75f8705e6461",
                column: "ConcurrencyStamp",
                value: "f38a7877-aaff-4043-9653-7189bca4c9f3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67bi2cf3-2950-4ffe-b1f0-75f8705e2469",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8db31ca1-0a88-460e-925b-6f9e81ba22ba", "AQAAAAEAACcQAAAAEIbsBBz3cvocYIXt9gv/WaJ5TUMPBqnyGn/ETy36+6ID8DHQXpR2BgkYDQlDbF6wRg==", "13aa49c1-a698-4a5f-809c-207ec59855bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67bq2cb3-1955-4sfe-b1f7-73f8705e2469",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23a34b3b-40fa-4482-ae73-07f4c3f84a4a", "AQAAAAEAACcQAAAAEIOdFH0txBT/ivdfFhrFoQNqUyeFCxRFYJN3GDsruTwY12P1ht58ink+D01ZB8c9cw==", "a5998928-9147-46c2-945c-00f40a48ef82" });
        }
    }
}

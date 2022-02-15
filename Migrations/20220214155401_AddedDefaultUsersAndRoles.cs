using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeaveManagement.Web.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "67cb2cf7-7950-4ffe-b1f0-75f8705e6461", "f38a7877-aaff-4043-9653-7189bca4c9f3", "Administrator", "ADMINISTRATOR" },
                    { "67aa2cf7-7951-4ffe-b1f0-76f8705e6461", "fc2a6d1b-a12a-4f70-9d0c-388cbe877582", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "67bi2cf3-2950-4ffe-b1f0-75f8705e2469", 0, "8db31ca1-0a88-460e-925b-6f9e81ba22ba", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEIbsBBz3cvocYIXt9gv/WaJ5TUMPBqnyGn/ETy36+6ID8DHQXpR2BgkYDQlDbF6wRg==", null, false, "13aa49c1-a698-4a5f-809c-207ec59855bb", null, false, "admin@localhost.com" },
                    { "67bq2cb3-1955-4sfe-b1f7-73f8705e2469", 0, "23a34b3b-40fa-4482-ae73-07f4c3f84a4a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", true, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEIOdFH0txBT/ivdfFhrFoQNqUyeFCxRFYJN3GDsruTwY12P1ht58ink+D01ZB8c9cw==", null, false, "a5998928-9147-46c2-945c-00f40a48ef82", null, false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "67cb2cf7-7950-4ffe-b1f0-75f8705e6461", "67bi2cf3-2950-4ffe-b1f0-75f8705e2469" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "67aa2cf7-7951-4ffe-b1f0-76f8705e6461", "67bq2cb3-1955-4sfe-b1f7-73f8705e2469" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "67cb2cf7-7950-4ffe-b1f0-75f8705e6461", "67bi2cf3-2950-4ffe-b1f0-75f8705e2469" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "67aa2cf7-7951-4ffe-b1f0-76f8705e6461", "67bq2cb3-1955-4sfe-b1f7-73f8705e2469" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67aa2cf7-7951-4ffe-b1f0-76f8705e6461");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67cb2cf7-7950-4ffe-b1f0-75f8705e6461");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67bi2cf3-2950-4ffe-b1f0-75f8705e2469");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67bq2cb3-1955-4sfe-b1f7-73f8705e2469");
        }
    }
}

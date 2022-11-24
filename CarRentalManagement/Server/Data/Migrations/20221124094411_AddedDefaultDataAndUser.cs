using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "0b27950c-4fd7-4eb3-ad31-9b0f11a1179a", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "f8b017af-f58b-42db-98ec-6fb43773498c", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "d7b8b469-156e-4866-aa5b-ded91766cde0", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEIUOrIjL/WeXMcNmBMcTqlWRUEQqMJlnDV7ekwQhczqJdKOU5JGXrC7ivfXbDJhOlw==", null, false, "2194b397-7212-4571-9fc6-6962350e9df2", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 24, 17, 44, 10, 466, DateTimeKind.Local).AddTicks(2155), new DateTime(2022, 11, 24, 17, 44, 10, 467, DateTimeKind.Local).AddTicks(3208), "Black", "System" },
                    { 2, "System", new DateTime(2022, 11, 24, 17, 44, 10, 467, DateTimeKind.Local).AddTicks(3985), new DateTime(2022, 11, 24, 17, 44, 10, 467, DateTimeKind.Local).AddTicks(3989), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 24, 17, 44, 10, 468, DateTimeKind.Local).AddTicks(5445), new DateTime(2022, 11, 24, 17, 44, 10, 468, DateTimeKind.Local).AddTicks(5459), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 24, 17, 44, 10, 468, DateTimeKind.Local).AddTicks(5463), new DateTime(2022, 11, 24, 17, 44, 10, 468, DateTimeKind.Local).AddTicks(5464), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 24, 17, 44, 10, 468, DateTimeKind.Local).AddTicks(8927), new DateTime(2022, 11, 24, 17, 44, 10, 468, DateTimeKind.Local).AddTicks(8935), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 11, 24, 17, 44, 10, 468, DateTimeKind.Local).AddTicks(8937), new DateTime(2022, 11, 24, 17, 44, 10, 468, DateTimeKind.Local).AddTicks(8938), "X5", "System" },
                    { 3, "System", new DateTime(2022, 11, 24, 17, 44, 10, 468, DateTimeKind.Local).AddTicks(8940), new DateTime(2022, 11, 24, 17, 44, 10, 468, DateTimeKind.Local).AddTicks(8941), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 11, 24, 17, 44, 10, 468, DateTimeKind.Local).AddTicks(8943), new DateTime(2022, 11, 24, 17, 44, 10, 468, DateTimeKind.Local).AddTicks(8944), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}

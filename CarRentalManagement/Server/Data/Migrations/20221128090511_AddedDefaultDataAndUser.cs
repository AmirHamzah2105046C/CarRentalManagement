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
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "73a29f5f-e83c-47fa-88d2-b894cdc79d32", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "d5248ad9-50cc-41b5-8bd1-130be83d435d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "00c0511f-c081-49bf-a31f-122184497a55", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEP8F6gvGnaTBt30Mprw/NbRtu3TFpQl+yINhm7+uuWeRuzng5edttXszB0Dq9cX+cg==", null, false, "31a4450a-7a45-4c15-a402-39369f8b324e", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Createdby", "DateCreated", "DateUpdated", "Name", "Updatedby" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 28, 17, 5, 10, 327, DateTimeKind.Local).AddTicks(4166), new DateTime(2022, 11, 28, 17, 5, 10, 329, DateTimeKind.Local).AddTicks(5522), "Black", "System" },
                    { 2, "System", new DateTime(2022, 11, 28, 17, 5, 10, 329, DateTimeKind.Local).AddTicks(7796), new DateTime(2022, 11, 28, 17, 5, 10, 329, DateTimeKind.Local).AddTicks(7808), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "Createdby", "DateCreated", "DateUpdated", "Name", "Updatedby" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 28, 17, 5, 10, 332, DateTimeKind.Local).AddTicks(4927), new DateTime(2022, 11, 28, 17, 5, 10, 332, DateTimeKind.Local).AddTicks(4955), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 28, 17, 5, 10, 332, DateTimeKind.Local).AddTicks(4962), new DateTime(2022, 11, 28, 17, 5, 10, 332, DateTimeKind.Local).AddTicks(4964), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "Createdby", "DateCreated", "DateUpdated", "Name", "Updatedby" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 28, 17, 5, 10, 333, DateTimeKind.Local).AddTicks(3263), new DateTime(2022, 11, 28, 17, 5, 10, 333, DateTimeKind.Local).AddTicks(3290), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 11, 28, 17, 5, 10, 333, DateTimeKind.Local).AddTicks(3297), new DateTime(2022, 11, 28, 17, 5, 10, 333, DateTimeKind.Local).AddTicks(3299), "X5", "System" },
                    { 3, "System", new DateTime(2022, 11, 28, 17, 5, 10, 333, DateTimeKind.Local).AddTicks(3302), new DateTime(2022, 11, 28, 17, 5, 10, 333, DateTimeKind.Local).AddTicks(3304), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 11, 28, 17, 5, 10, 333, DateTimeKind.Local).AddTicks(3306), new DateTime(2022, 11, 28, 17, 5, 10, 333, DateTimeKind.Local).AddTicks(3309), "Rav4", "System" }
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
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
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

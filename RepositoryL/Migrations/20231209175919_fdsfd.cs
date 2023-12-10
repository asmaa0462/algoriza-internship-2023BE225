using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RepositoryL.Migrations
{
    /// <inheritdoc />
    public partial class fdsfd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "001feb12-a50f-46be-90ac-7680d4adb6cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "230d6ae4-3991-4290-a8bd-04f2a17f2e5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2243a98-9808-43b6-b5a1-086720b9c40f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "242999a3-ee43-4fcc-b3ae-3735aed867b0", null, "Doctor", null },
                    { "2a1c55f1-93e1-4f12-9f63-bf29332c1941", null, "Admin", null },
                    { "91796624-f5a4-4b86-8bc4-548ce9e34e8e", null, "Patient", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "242999a3-ee43-4fcc-b3ae-3735aed867b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a1c55f1-93e1-4f12-9f63-bf29332c1941");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91796624-f5a4-4b86-8bc4-548ce9e34e8e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "001feb12-a50f-46be-90ac-7680d4adb6cc", "3", "Docotr", "Patient" },
                    { "230d6ae4-3991-4290-a8bd-04f2a17f2e5e", "2", "Doctor", "Doctor" },
                    { "f2243a98-9808-43b6-b5a1-086720b9c40f", "1", "Admin", "Admin" }
                });
        }
    }
}

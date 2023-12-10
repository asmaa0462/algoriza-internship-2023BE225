using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryL.Migrations
{
    /// <inheritdoc />
    public partial class howfds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "Phone",
                value: "0123546");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "Phone",
                value: "");
        }
    }
}

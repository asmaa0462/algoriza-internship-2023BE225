using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryL.Migrations
{
    /// <inheritdoc />
    public partial class how : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PatientId",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PatientId",
                table: "Users",
                type: "int",
                nullable: true);
        }
    }
}

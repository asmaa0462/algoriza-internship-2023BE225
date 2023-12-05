using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryL.Migrations
{
    /// <inheritdoc />
    public partial class Fifth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "bookId",
                table: "TimeAppointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    bookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookState = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.bookId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TimeAppointment_bookId",
                table: "TimeAppointment",
                column: "bookId");

            migrationBuilder.AddForeignKey(
                name: "FK_TimeAppointment_Booking_bookId",
                table: "TimeAppointment",
                column: "bookId",
                principalTable: "Booking",
                principalColumn: "bookId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TimeAppointment_Booking_bookId",
                table: "TimeAppointment");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_TimeAppointment_bookId",
                table: "TimeAppointment");

            migrationBuilder.DropColumn(
                name: "bookId",
                table: "TimeAppointment");
        }
    }
}

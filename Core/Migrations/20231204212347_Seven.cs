using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    /// <inheritdoc />
    public partial class Seven : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "discountId",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Discount",
                columns: table => new
                {
                    discountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountCode = table.Column<int>(type: "int", nullable: false),
                    DiscountState = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount", x => x.discountId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_discountId",
                table: "Booking",
                column: "discountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Discount_discountId",
                table: "Booking",
                column: "discountId",
                principalTable: "Discount",
                principalColumn: "discountId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Discount_discountId",
                table: "Booking");

            migrationBuilder.DropTable(
                name: "Discount");

            migrationBuilder.DropIndex(
                name: "IX_Booking_discountId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "discountId",
                table: "Booking");
        }
    }
}

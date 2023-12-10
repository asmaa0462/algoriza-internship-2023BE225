using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RepositoryL.Migrations
{
    /// <inheritdoc />
    public partial class Lo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateBirth", "Discriminator", "Email", "FirstName", "Gender", "LastName", "Password", "Phone", "SpecializationId", "doctorid", "image", "price" },
                values: new object[,]
                {
                    { 1, new DateOnly(1995, 12, 13), "Doctor", "ahmedali@bit.com", "Ahmed", 1, "Ali", "PO-k?$rn", "012345678", 8, 0, "images/1.jpeg", 200 },
                    { 2, new DateOnly(1978, 5, 2), "Doctor", "mohamedhosam@bit.com", "Mohamed", 1, "Hosam", "(UHp'Nkh", "02456972", 7, 0, "images/2.jpeg", 200 },
                    { 3, new DateOnly(1985, 10, 1), "Doctor", "mahmoudwael@bit.com", "Mahmoud", 1, "Wael", "", "01246875", 5, 0, "images/3.jpeg", 200 },
                    { 4, new DateOnly(1992, 4, 12), "Doctor", "hamzawaleed@bit.com", "Hamza", 1, "Waleed", "", "012364799", 4, 0, "images/4.jpeg", 200 },
                    { 5, new DateOnly(1993, 3, 20), "Doctor", "omartaher@bit.com", "Omar", 1, "Taher", "", "01268958", 1, 0, "images/5.jpeg", 200 },
                    { 6, new DateOnly(1992, 8, 25), "Doctor", "yousefhamed@bit.com", "Yousef", 1, "Hamed", "", "0145588", 2, 0, "images/6.jpeg", 200 },
                    { 7, new DateOnly(1997, 7, 5), "Doctor", "khaledramzy@bit.com", "Khaled", 1, "Razmy", "", "013678526", 3, 0, "images/7.jpeg", 200 },
                    { 8, new DateOnly(1999, 11, 1), "Doctor", "yasersayed@bit.com", "yaser", 0, "sayed", "", "", 9, 0, "images/8.jpeg", 200 },
                    { 9, new DateOnly(1987, 5, 10), "Doctor", "amrahmed", "Amr", 1, "Ahmed", "", "0123648796", 10, 0, "images/9.jpeg", 200 },
                    { 10, new DateOnly(1995, 2, 9), "Doctor", "ayaahmed", "Aya", 0, "Ahmed", "", "", 11, 0, "images/10.jpeg", 200 },
                    { 11, new DateOnly(1996, 6, 16), "Doctor", "hanaamagdy@bit.com", "Hanaa", 0, "Magdy", "", "0197586413", 12, 0, "images/11.jpeg", 200 },
                    { 12, new DateOnly(1998, 4, 6), "Doctor", "halamodamed@bit.com", "Hala", 0, "Mohamed", "", "010955487652", 8, 0, "images/12.jpeg", 200 },
                    { 13, new DateOnly(1994, 2, 28), "Doctor", "fatmasafwt@@bit.com", "Fatma", 0, "Safwt", "", "01269753684", 12, 0, "images/13.jpeg", 200 },
                    { 14, new DateOnly(1991, 6, 3), "Doctor", "masaadham@bit.com", "yara", 0, "Ayman", "", "0125873", 3, 0, "images/14.jpeg", 200 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Users");
        }
    }
}

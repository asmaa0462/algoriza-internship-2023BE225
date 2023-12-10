using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RepositoryL.Migrations
{
    /// <inheritdoc />
    public partial class ne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Days = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    discountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountCode = table.Column<int>(type: "int", nullable: false),
                    DiscountState = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.discountId);
                });

            migrationBuilder.CreateTable(
                name: "Specializations",
                columns: table => new
                {
                    SpecializationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecializationName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializations", x => x.SpecializationId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    bookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookState = table.Column<int>(type: "int", nullable: false),
                    discountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.bookId);
                    table.ForeignKey(
                        name: "FK_Bookings_Discounts_discountId",
                        column: x => x.discountId,
                        principalTable: "Discounts",
                        principalColumn: "discountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DateBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    price = table.Column<int>(type: "int", nullable: true),
                    SpecializationId = table.Column<int>(type: "int", nullable: true),
                    doctorid = table.Column<int>(type: "int", nullable: true),
                    numberOfRequests = table.Column<int>(type: "int", nullable: true),
                    NumberofRequest = table.Column<int>(type: "int", nullable: true),
                    PatientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Specializations_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specializations",
                        principalColumn: "SpecializationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimeAppointments",
                columns: table => new
                {
                    timeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    bookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeAppointments", x => x.timeId);
                    table.ForeignKey(
                        name: "FK_TimeAppointments_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "AppointmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TimeAppointments_Bookings_bookId",
                        column: x => x.bookId,
                        principalTable: "Bookings",
                        principalColumn: "bookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorsAppointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "int", nullable: false),
                    doctorid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorsAppointments", x => new { x.doctorid, x.AppointmentId });
                    table.ForeignKey(
                        name: "FK_DoctorsAppointments_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "AppointmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorsAppointments_Users_doctorid",
                        column: x => x.doctorid,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientsBookings",
                columns: table => new
                {
                    bookId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientsBookings", x => new { x.bookId, x.PatientId });
                    table.ForeignKey(
                        name: "FK_PatientsBookings_Bookings_bookId",
                        column: x => x.bookId,
                        principalTable: "Bookings",
                        principalColumn: "bookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientsBookings_Users_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "27da7809-cabc-472c-844c-98e998a509f4", null, "Patient", null },
                    { "37c5e62a-8d6a-45f2-b652-090e9059a15d", null, "Doctor", null },
                    { "c653cbf9-52b0-4cb5-8436-b08171dec1c3", null, "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "SpecializationId", "SpecializationName" },
                values: new object[,]
                {
                    { 1, "Genetic pathology" },
                    { 2, "Ophthalmology" },
                    { 3, "Oncology" },
                    { 4, "Cardiology " },
                    { 5, "Hematology " },
                    { 6, "otolaryngology " },
                    { 7, "Psychiatry " },
                    { 8, "Liver Transplant Surgery" },
                    { 9, "Pediatric surgery" },
                    { 10, "Foot and ankle orthopedics" },
                    { 11, "Dentistry" },
                    { 12, "Gastroenterology" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateBirth", "Discriminator", "Email", "FirstName", "Gender", "LastName", "Password", "Phone", "SpecializationId", "doctorid", "image", "numberOfRequests", "price" },
                values: new object[,]
                {
                    { 1, new DateTime(1995, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "ahmedali@bit.com", "Ahmed", 1, "Ali", "PO-k?$rn", "012345678", 8, 0, "images/1.jpeg", 0, 200 },
                    { 2, new DateTime(1978, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "mohamedhosam@bit.com", "Mohamed", 1, "Hosam", "(UHp'Nkh", "02456972", 7, 0, "images/2.jpeg", 0, 200 },
                    { 3, new DateTime(1985, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "mahmoudwael@bit.com", "Mahmoud", 1, "Wael", "n`6Jy}+z", "01246875", 5, 0, "images/3.jpeg", 0, 200 },
                    { 4, new DateTime(1992, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "hamzawaleed@bit.com", "Hamza", 1, "Waleed", "6(@Ksr5c", "012364799", 4, 0, "images/4.jpeg", 0, 200 },
                    { 5, new DateTime(1993, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "omartaher@bit.com", "Omar", 1, "Taher", "6+d$e#Js", "01268958", 1, 0, "images/5.jpeg", 0, 200 },
                    { 6, new DateTime(1992, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "yousefhamed@bit.com", "Yousef", 1, "Hamed", "qt;<}Kjh", "0145588", 2, 0, "images/6.jpeg", 0, 200 },
                    { 7, new DateTime(1997, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "khaledramzy@bit.com", "Khaled", 1, "Razmy", "8)Q`wkP$", "013678526", 3, 0, "images/7.jpeg", 0, 200 },
                    { 8, new DateTime(1999, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "yasersayed@bit.com", "yaser", 1, "sayed", "P<!=W6fe", "01369885", 9, 0, "images/8.jpeg", 0, 200 },
                    { 9, new DateTime(1987, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "amrahmed", "Amr", 1, "Ahmed", "l)OJ*VkB", "0123648796", 10, 0, "images/9.jpeg", 0, 200 },
                    { 10, new DateTime(1995, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "ayaahmed", "Aya", 0, "Ahmed", "ynz#Jpsg", "0123546", 11, 0, "images/10.jpeg", 0, 200 },
                    { 11, new DateTime(1996, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "hanaamagdy@bit.com", "Hanaa", 0, "Magdy", "zNH:gT7w", "0197586413", 12, 0, "images/11.jpeg", 0, 200 },
                    { 12, new DateTime(1998, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "halamodamed@bit.com", "Hala", 0, "Mohamed", "#;b*D+x$", "010955487652", 8, 0, "images/12.jpeg", 0, 200 },
                    { 13, new DateTime(1994, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "fatmasafwt@@bit.com", "Fatma", 0, "Safwt", "]Q,X$|ri", "01269753684", 12, 0, "images/13.jpeg", 0, 200 },
                    { 14, new DateTime(1991, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doctor", "masaadham@bit.com", "yara", 0, "Ayman", "VXFlvL2d", "0125873", 3, 0, "images/14.jpeg", 0, 200 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_discountId",
                table: "Bookings",
                column: "discountId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorsAppointments_AppointmentId",
                table: "DoctorsAppointments",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientsBookings_PatientId",
                table: "PatientsBookings",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeAppointments_AppointmentId",
                table: "TimeAppointments",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeAppointments_bookId",
                table: "TimeAppointments",
                column: "bookId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SpecializationId",
                table: "Users",
                column: "SpecializationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DoctorsAppointments");

            migrationBuilder.DropTable(
                name: "PatientsBookings");

            migrationBuilder.DropTable(
                name: "TimeAppointments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Specializations");

            migrationBuilder.DropTable(
                name: "Discounts");
        }
    }
}

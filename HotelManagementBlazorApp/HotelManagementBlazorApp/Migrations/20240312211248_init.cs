using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelManagementBlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoomType",
                columns: table => new
                {
                    RoomTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PricePerNight = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomType", x => x.RoomTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Guest",
                columns: table => new
                {
                    GuestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCheckedOut = table.Column<bool>(type: "bit", nullable: false),
                    RoomTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest", x => x.GuestId);
                    table.ForeignKey(
                        name: "FK_Guest_RoomType_RoomTypeId",
                        column: x => x.RoomTypeId,
                        principalTable: "RoomType",
                        principalColumn: "RoomTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "RoomType",
                columns: new[] { "RoomTypeId", "PricePerNight", "TypeName" },
                values: new object[,]
                {
                    { 1, 1500m, "Standard" },
                    { 2, 2500m, "Premium" },
                    { 3, 3500m, "Deluxe" }
                });

            migrationBuilder.InsertData(
                table: "Guest",
                columns: new[] { "GuestId", "CheckInDate", "CheckOutDate", "DateOfBirth", "Email", "FirstName", "IsCheckedOut", "LastName", "PaymentStatus", "PhoneNumber", "RoomTypeId", "TotalAmountPaid" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SaidulIslam@gmail.com", "Saidul", true, "Islam", "Paid", "1234567890", 2, 2500m },
                    { 2, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1996, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ASMSayem@gmail.com", "A.S.M", false, "Sayem", "Paid", "1234567890", 1, 1500m },
                    { 3, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MohammadMaruf@gmail.com", "Mohammad", true, "Maruf", "Paid", "1234567890", 3, 3500m },
                    { 4, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1994, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "AbdullahToha@gmail.com", "Abdullah", false, "Toha", "Paid", "1234567890", 2, 2500m },
                    { 5, new DateTime(2024, 3, 12, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2024, 3, 16, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(1995, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "MinhajChowdhury@gmail.com", "Minhaj", true, "Chowdhury", "Paid", "1234567890", 3, 3500m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Guest_RoomTypeId",
                table: "Guest",
                column: "RoomTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guest");

            migrationBuilder.DropTable(
                name: "RoomType");
        }
    }
}

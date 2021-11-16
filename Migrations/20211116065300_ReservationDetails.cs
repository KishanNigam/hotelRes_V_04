using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace hotelRes_V_03.Migrations
{
    public partial class ReservationDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuestId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hotel_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckIn_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOut_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    number_of_guest = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reservations");
        }
    }
}

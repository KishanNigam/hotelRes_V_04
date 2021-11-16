using Microsoft.EntityFrameworkCore.Migrations;

namespace hotelRes_V_03.Migrations
{
    public partial class InvoiceBillDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "invoice_Bills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Guest_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hotel_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    payment_method = table.Column<int>(type: "int", nullable: false),
                    room_service_charge = table.Column<int>(type: "int", nullable: false),
                    total_cost = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoice_Bills", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "invoice_Bills");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentityProject.DataAccessLayer.Migrations
{
    public partial class mig_add_electric_bill_amount_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "ElectricBills",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "ElectricBills");
        }
    }
}

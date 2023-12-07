using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentityProject.DataAccessLayer.Migrations
{
    public partial class mig_add_electric_bill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElectricBills",
                columns: table => new
                {
                    ElectricBillID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillingPeriod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaidStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricBills", x => x.ElectricBillID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElectricBills");
        }
    }
}

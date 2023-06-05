using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentityProject.DataAccessLayer.Migrations
{
    public partial class mig_add_customer_relation_process : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReceiverID",
                table: "CustomerAccountProcesses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SenderID",
                table: "CustomerAccountProcesses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccountProcesses_ReceiverID",
                table: "CustomerAccountProcesses",
                column: "ReceiverID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccountProcesses_SenderID",
                table: "CustomerAccountProcesses",
                column: "SenderID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_ReceiverID",
                table: "CustomerAccountProcesses",
                column: "ReceiverID",
                principalTable: "CustomerAccounts",
                principalColumn: "CustomerAccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_SenderID",
                table: "CustomerAccountProcesses",
                column: "SenderID",
                principalTable: "CustomerAccounts",
                principalColumn: "CustomerAccountID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_ReceiverID",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccountProcesses_CustomerAccounts_SenderID",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccountProcesses_ReceiverID",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccountProcesses_SenderID",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropColumn(
                name: "ReceiverID",
                table: "CustomerAccountProcesses");

            migrationBuilder.DropColumn(
                name: "SenderID",
                table: "CustomerAccountProcesses");
        }
    }
}

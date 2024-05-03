using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrators.MSSQL.Migrations
{
    /// <inheritdoc />
    public partial class ProposalField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Proposal_OrdererId",
                table: "Proposal",
                column: "OrdererId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proposal_Account_OrdererId",
                table: "Proposal",
                column: "OrdererId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proposal_Account_OrdererId",
                table: "Proposal");

            migrationBuilder.DropIndex(
                name: "IX_Proposal_OrdererId",
                table: "Proposal");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class RenameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenditures_User_UserId",
                table: "Expenditures");

            migrationBuilder.DropForeignKey(
                name: "FK_Incomes_User_UserId",
                table: "Incomes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Incomes",
                table: "Incomes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Expenditures",
                table: "Expenditures");

            migrationBuilder.RenameTable(
                name: "Incomes",
                newName: "Income");

            migrationBuilder.RenameTable(
                name: "Expenditures",
                newName: "Expenditure");

            migrationBuilder.RenameIndex(
                name: "IX_Incomes_UserId",
                table: "Income",
                newName: "IX_Income_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Expenditures_UserId",
                table: "Expenditure",
                newName: "IX_Expenditure_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Income",
                table: "Income",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Expenditure",
                table: "Expenditure",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenditure_User_UserId",
                table: "Expenditure",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Income_User_UserId",
                table: "Income",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Expenditure_User_UserId",
                table: "Expenditure");

            migrationBuilder.DropForeignKey(
                name: "FK_Income_User_UserId",
                table: "Income");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Income",
                table: "Income");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Expenditure",
                table: "Expenditure");

            migrationBuilder.RenameTable(
                name: "Income",
                newName: "Incomes");

            migrationBuilder.RenameTable(
                name: "Expenditure",
                newName: "Expenditures");

            migrationBuilder.RenameIndex(
                name: "IX_Income_UserId",
                table: "Incomes",
                newName: "IX_Incomes_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Expenditure_UserId",
                table: "Expenditures",
                newName: "IX_Expenditures_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Incomes",
                table: "Incomes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Expenditures",
                table: "Expenditures",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Expenditures_User_UserId",
                table: "Expenditures",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incomes_User_UserId",
                table: "Incomes",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

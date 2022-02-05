using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeshanSLIIT.Migrations
{
    public partial class updateTransferTable_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Transfers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Transfers");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcClientes.Migrations
{
    public partial class Email : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Email",
                table: "Cliente",
                type: "int",
                maxLength: 80,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Cliente");
        }
    }
}

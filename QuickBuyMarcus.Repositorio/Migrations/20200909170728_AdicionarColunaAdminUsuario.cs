using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBuyMarcus.Repositorio.Migrations
{
    public partial class AdicionarColunaAdminUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EAdministrador",
                table: "Usuarios",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EAdministrador",
                table: "Usuarios");
        }
    }
}

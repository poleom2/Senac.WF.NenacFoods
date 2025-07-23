using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SenacFoods.Migrations
{
    /// <inheritdoc />
    public partial class perfil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PerfilId",
                table: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "Perfil",
                table: "Usuarios",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Perfil",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "PerfilId",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

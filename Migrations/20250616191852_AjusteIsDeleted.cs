using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catholirism.Migrations
{
    /// <inheritdoc />
    public partial class AjusteIsDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Agendamentos",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Agendamentos");
        }
    }
}

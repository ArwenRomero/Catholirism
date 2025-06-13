using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catholirism.Migrations
{
    /// <inheritdoc />
    public partial class AddImagemUrlToDestino : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagemUrl",
                table: "Locais",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagemUrl",
                table: "Locais");
        }
    }
}

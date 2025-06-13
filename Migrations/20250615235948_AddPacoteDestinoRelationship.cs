using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catholirism.Migrations
{
    /// <inheritdoc />
    public partial class AddPacoteDestinoRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PacoteDestinos",
                columns: table => new
                {
                    PacoteId = table.Column<int>(type: "INTEGER", nullable: false),
                    DestinoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacoteDestinos", x => new { x.PacoteId, x.DestinoId });
                    table.ForeignKey(
                        name: "FK_PacoteDestinos_Destinos_DestinoId",
                        column: x => x.DestinoId,
                        principalTable: "Destinos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PacoteDestinos_Pacotes_Turisticos_PacoteId",
                        column: x => x.PacoteId,
                        principalTable: "Pacotes_Turisticos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PacoteDestinos_DestinoId",
                table: "PacoteDestinos",
                column: "DestinoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PacoteDestinos");
        }
    }
}

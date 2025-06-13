using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Catholirism.Migrations
{
    /// <inheritdoc />
    public partial class RenameTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Destinos_Pacotes_Turisticos_Pacote_TuristicoId",
                table: "Destinos");

            migrationBuilder.DropForeignKey(
                name: "FK_PacoteDestinos_Destinos_DestinoId",
                table: "PacoteDestinos");

            migrationBuilder.DropForeignKey(
                name: "FK_PacoteDestinos_Pacotes_Turisticos_PacoteId",
                table: "PacoteDestinos");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Clientes_ClienteId",
                table: "Reservas");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservas_Pacotes_Turisticos_PacoteId",
                table: "Reservas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservas",
                table: "Reservas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pacotes_Turisticos",
                table: "Pacotes_Turisticos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PacoteDestinos",
                table: "PacoteDestinos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Destinos",
                table: "Destinos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Reservas",
                newName: "Agendamentos");

            migrationBuilder.RenameTable(
                name: "Pacotes_Turisticos",
                newName: "PacotesTurismo");

            migrationBuilder.RenameTable(
                name: "PacoteDestinos",
                newName: "PacoteLocais");

            migrationBuilder.RenameTable(
                name: "Destinos",
                newName: "Locais");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Clientela");

            migrationBuilder.RenameIndex(
                name: "IX_Reservas_PacoteId",
                table: "Agendamentos",
                newName: "IX_Agendamentos_PacoteId");

            migrationBuilder.RenameIndex(
                name: "IX_Reservas_ClienteId",
                table: "Agendamentos",
                newName: "IX_Agendamentos_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_PacoteDestinos_DestinoId",
                table: "PacoteLocais",
                newName: "IX_PacoteLocais_DestinoId");

            migrationBuilder.RenameIndex(
                name: "IX_Destinos_Pacote_TuristicoId",
                table: "Locais",
                newName: "IX_Locais_Pacote_TuristicoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agendamentos",
                table: "Agendamentos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PacotesTurismo",
                table: "PacotesTurismo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PacoteLocais",
                table: "PacoteLocais",
                columns: new[] { "PacoteId", "DestinoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locais",
                table: "Locais",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientela",
                table: "Clientela",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Clientela_ClienteId",
                table: "Agendamentos",
                column: "ClienteId",
                principalTable: "Clientela",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_PacotesTurismo_PacoteId",
                table: "Agendamentos",
                column: "PacoteId",
                principalTable: "PacotesTurismo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locais_PacotesTurismo_Pacote_TuristicoId",
                table: "Locais",
                column: "Pacote_TuristicoId",
                principalTable: "PacotesTurismo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PacoteLocais_Locais_DestinoId",
                table: "PacoteLocais",
                column: "DestinoId",
                principalTable: "Locais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PacoteLocais_PacotesTurismo_PacoteId",
                table: "PacoteLocais",
                column: "PacoteId",
                principalTable: "PacotesTurismo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Clientela_ClienteId",
                table: "Agendamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_PacotesTurismo_PacoteId",
                table: "Agendamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Locais_PacotesTurismo_Pacote_TuristicoId",
                table: "Locais");

            migrationBuilder.DropForeignKey(
                name: "FK_PacoteLocais_Locais_DestinoId",
                table: "PacoteLocais");

            migrationBuilder.DropForeignKey(
                name: "FK_PacoteLocais_PacotesTurismo_PacoteId",
                table: "PacoteLocais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PacotesTurismo",
                table: "PacotesTurismo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PacoteLocais",
                table: "PacoteLocais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locais",
                table: "Locais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientela",
                table: "Clientela");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agendamentos",
                table: "Agendamentos");

            migrationBuilder.RenameTable(
                name: "PacotesTurismo",
                newName: "Pacotes_Turisticos");

            migrationBuilder.RenameTable(
                name: "PacoteLocais",
                newName: "PacoteDestinos");

            migrationBuilder.RenameTable(
                name: "Locais",
                newName: "Destinos");

            migrationBuilder.RenameTable(
                name: "Clientela",
                newName: "Clientes");

            migrationBuilder.RenameTable(
                name: "Agendamentos",
                newName: "Reservas");

            migrationBuilder.RenameIndex(
                name: "IX_PacoteLocais_DestinoId",
                table: "PacoteDestinos",
                newName: "IX_PacoteDestinos_DestinoId");

            migrationBuilder.RenameIndex(
                name: "IX_Locais_Pacote_TuristicoId",
                table: "Destinos",
                newName: "IX_Destinos_Pacote_TuristicoId");

            migrationBuilder.RenameIndex(
                name: "IX_Agendamentos_PacoteId",
                table: "Reservas",
                newName: "IX_Reservas_PacoteId");

            migrationBuilder.RenameIndex(
                name: "IX_Agendamentos_ClienteId",
                table: "Reservas",
                newName: "IX_Reservas_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pacotes_Turisticos",
                table: "Pacotes_Turisticos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PacoteDestinos",
                table: "PacoteDestinos",
                columns: new[] { "PacoteId", "DestinoId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Destinos",
                table: "Destinos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservas",
                table: "Reservas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Destinos_Pacotes_Turisticos_Pacote_TuristicoId",
                table: "Destinos",
                column: "Pacote_TuristicoId",
                principalTable: "Pacotes_Turisticos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PacoteDestinos_Destinos_DestinoId",
                table: "PacoteDestinos",
                column: "DestinoId",
                principalTable: "Destinos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PacoteDestinos_Pacotes_Turisticos_PacoteId",
                table: "PacoteDestinos",
                column: "PacoteId",
                principalTable: "Pacotes_Turisticos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Clientes_ClienteId",
                table: "Reservas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "ClienteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservas_Pacotes_Turisticos_PacoteId",
                table: "Reservas",
                column: "PacoteId",
                principalTable: "Pacotes_Turisticos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

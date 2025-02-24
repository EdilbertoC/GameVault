using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameVault.Migrations
{
    /// <inheritdoc />
    public partial class PopularReview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Reviews(Comentario, Nota, HorasDeJogo, JogoId, DataAvaliacao) VALUES('Jogo muito bom', 10, 20, 3, '10/10/2025')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Reviews");
        }
    }
}

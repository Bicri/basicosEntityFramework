using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace basicoEF.Context.Migrations
{
    /// <inheritdoc />
    public partial class MIG005 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CinePelicula_Pelicula_PeliculasPeliculaId",
                table: "CinePelicula");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pelicula",
                table: "Pelicula");

            migrationBuilder.RenameTable(
                name: "Pelicula",
                newName: "Peliculas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Peliculas",
                table: "Peliculas",
                column: "PeliculaId");

            migrationBuilder.AddForeignKey(
                name: "FK_CinePelicula_Peliculas_PeliculasPeliculaId",
                table: "CinePelicula",
                column: "PeliculasPeliculaId",
                principalTable: "Peliculas",
                principalColumn: "PeliculaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CinePelicula_Peliculas_PeliculasPeliculaId",
                table: "CinePelicula");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Peliculas",
                table: "Peliculas");

            migrationBuilder.RenameTable(
                name: "Peliculas",
                newName: "Pelicula");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pelicula",
                table: "Pelicula",
                column: "PeliculaId");

            migrationBuilder.AddForeignKey(
                name: "FK_CinePelicula_Pelicula_PeliculasPeliculaId",
                table: "CinePelicula",
                column: "PeliculasPeliculaId",
                principalTable: "Pelicula",
                principalColumn: "PeliculaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

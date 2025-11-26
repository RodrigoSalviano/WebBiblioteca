using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebBiblioteca.Migrations
{
    /// <inheritdoc />
    public partial class ListasClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autores_Autores_Autoresid",
                table: "Autores");

            migrationBuilder.DropForeignKey(
                name: "FK_Editora_Editora_Editoraid",
                table: "Editora");

            migrationBuilder.RenameColumn(
                name: "Editoraid",
                table: "Editora",
                newName: "Autoresid");

            migrationBuilder.RenameIndex(
                name: "IX_Editora_Editoraid",
                table: "Editora",
                newName: "IX_Editora_Autoresid");

            migrationBuilder.RenameColumn(
                name: "Autoresid",
                table: "Autores",
                newName: "Livrosid");

            migrationBuilder.RenameIndex(
                name: "IX_Autores_Autoresid",
                table: "Autores",
                newName: "IX_Autores_Livrosid");

            migrationBuilder.AddForeignKey(
                name: "FK_Autores_Livros_Livrosid",
                table: "Autores",
                column: "Livrosid",
                principalTable: "Livros",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Editora_Autores_Autoresid",
                table: "Editora",
                column: "Autoresid",
                principalTable: "Autores",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autores_Livros_Livrosid",
                table: "Autores");

            migrationBuilder.DropForeignKey(
                name: "FK_Editora_Autores_Autoresid",
                table: "Editora");

            migrationBuilder.RenameColumn(
                name: "Autoresid",
                table: "Editora",
                newName: "Editoraid");

            migrationBuilder.RenameIndex(
                name: "IX_Editora_Autoresid",
                table: "Editora",
                newName: "IX_Editora_Editoraid");

            migrationBuilder.RenameColumn(
                name: "Livrosid",
                table: "Autores",
                newName: "Autoresid");

            migrationBuilder.RenameIndex(
                name: "IX_Autores_Livrosid",
                table: "Autores",
                newName: "IX_Autores_Autoresid");

            migrationBuilder.AddForeignKey(
                name: "FK_Autores_Autores_Autoresid",
                table: "Autores",
                column: "Autoresid",
                principalTable: "Autores",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Editora_Editora_Editoraid",
                table: "Editora",
                column: "Editoraid",
                principalTable: "Editora",
                principalColumn: "id");
        }
    }
}

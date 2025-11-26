using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebBiblioteca.Migrations
{
    /// <inheritdoc />
    public partial class Class : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "publicacao",
                table: "Editora");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Autores",
                newName: "nome");

            migrationBuilder.AlterColumn<string>(
                name: "titulo",
                table: "Livros",
                type: "nvarchar(120)",
                maxLength: 120,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "genero",
                table: "Livros",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "publicacao",
                table: "Livros",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "volume",
                table: "Livros",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Editora",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Autores",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nacionalidade",
                table: "Autores",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "publicacao",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "volume",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "nacionalidade",
                table: "Autores");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Autores",
                newName: "Nome");

            migrationBuilder.AlterColumn<string>(
                name: "titulo",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(120)",
                oldMaxLength: 120,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "genero",
                table: "Livros",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Editora",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "publicacao",
                table: "Editora",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Autores",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70,
                oldNullable: true);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class ActualizarColumnasDeTareas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tareas",
                table: "Tareas");

            migrationBuilder.RenameTable(
                name: "Tareas",
                newName: "tareas");

            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "tareas",
                newName: "titulo");

            migrationBuilder.RenameColumn(
                name: "Orden",
                table: "tareas",
                newName: "orden");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "tareas",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tareas",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                table: "tareas",
                newName: "fecha_creacion");

            migrationBuilder.AlterColumn<string>(
                name: "titulo",
                table: "tareas",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_tareas",
                table: "tareas",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tareas",
                table: "tareas");

            migrationBuilder.RenameTable(
                name: "tareas",
                newName: "Tareas");

            migrationBuilder.RenameColumn(
                name: "titulo",
                table: "Tareas",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "orden",
                table: "Tareas",
                newName: "Orden");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "Tareas",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Tareas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "fecha_creacion",
                table: "Tareas",
                newName: "FechaCreacion");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Tareas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tareas",
                table: "Tareas",
                column: "Id");
        }
    }
}

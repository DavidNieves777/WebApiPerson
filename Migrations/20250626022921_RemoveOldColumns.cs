using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiPerson.Migrations
{
    /// <inheritdoc />
    public partial class RemoveOldColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Personas",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Personas",
                newName: "Edad");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Personas",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Edad",
                table: "Personas",
                newName: "Age");
        }
    }
}

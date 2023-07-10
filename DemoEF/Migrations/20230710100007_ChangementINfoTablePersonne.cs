using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoEF.Migrations
{
    /// <inheritdoc />
    public partial class ChangementINfoTablePersonne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Personnes",
                newName: "LastName");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Personnes",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Personnes",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Personnes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);
        }
    }
}

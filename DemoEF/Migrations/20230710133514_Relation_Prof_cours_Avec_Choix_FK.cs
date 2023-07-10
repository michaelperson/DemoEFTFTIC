using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoEF.Migrations
{
    /// <inheritdoc />
    public partial class Relation_Prof_cours_Avec_Choix_FK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Professors_Professor_ID1",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Professor_ID1",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Professor_ID1",
                table: "Courses");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Professor_ID",
                table: "Courses",
                column: "Professor_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Professors_Professor_ID",
                table: "Courses",
                column: "Professor_ID",
                principalTable: "Professors",
                principalColumn: "Professor_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Professors_Professor_ID",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Professor_ID",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "Professor_ID1",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Professor_ID1",
                table: "Courses",
                column: "Professor_ID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Professors_Professor_ID1",
                table: "Courses",
                column: "Professor_ID1",
                principalTable: "Professors",
                principalColumn: "Professor_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

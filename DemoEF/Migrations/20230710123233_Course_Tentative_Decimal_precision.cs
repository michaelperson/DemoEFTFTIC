using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoEF.Migrations
{
    /// <inheritdoc />
    public partial class Course_Tentative_Decimal_precision : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Course_ID = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Course_Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Course_Ects = table.Column<decimal>(type: "decimal(3,1)", precision: 3, scale: 1, nullable: false),
                    Professor_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Course_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}

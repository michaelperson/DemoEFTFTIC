using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoEF.Migrations
{
    /// <inheritdoc />
    public partial class Add_Prof : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Professors",
                columns: table => new
                {
                    Professor_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Professor_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Professor_Surname = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Section_ID = table.Column<int>(type: "int", nullable: false),
                    Professor_Office = table.Column<int>(type: "int", nullable: false),
                    Professor_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Professor_HireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Professor_Wage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prof", x => x.Professor_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Professors");
        }
    }
}

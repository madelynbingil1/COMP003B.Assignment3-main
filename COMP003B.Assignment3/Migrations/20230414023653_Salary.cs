using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP003B.Assignment3.Migrations
{
    /// <inheritdoc />
    public partial class Salary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Salary",
                table: "Employee",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Employee");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP003B.Assignment3.Migrations
{
    /// <inheritdoc />
    public partial class EmpName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmpName",
                table: "Employee",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Occupation",
                table: "Employee",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpName",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Occupation",
                table: "Employee");
        }
    }
}

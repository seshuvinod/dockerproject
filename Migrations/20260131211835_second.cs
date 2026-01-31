using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dockerproject.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DbSet",
                table: "DbSet");

            migrationBuilder.RenameTable(
                name: "DbSet",
                newName: "Employees");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "DbSet");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DbSet",
                table: "DbSet",
                column: "Id");
        }
    }
}

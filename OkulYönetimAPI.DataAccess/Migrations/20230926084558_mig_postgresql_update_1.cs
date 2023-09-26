using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkulYönetimAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_postgresql_update_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "examnotes",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "homeworks",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "examnotes",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "homeworks",
                table: "Students");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkulYönetimAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updatedatabae : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "schooladress",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "schoolphone",
                table: "Schools",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "schooladress",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "schoolphone",
                table: "Schools");
        }
    }
}

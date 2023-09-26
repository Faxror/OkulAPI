using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkulYönetimAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_postgresql_update_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_HomeworkandExams_ID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ıd",
                table: "HomeworkandExams");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Students",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ıd",
                table: "HomeworkandExams",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_ID",
                table: "Students",
                column: "ID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_HomeworkandExams_ID",
                table: "Students",
                column: "ID",
                principalTable: "HomeworkandExams",
                principalColumn: "ID");
        }
    }
}

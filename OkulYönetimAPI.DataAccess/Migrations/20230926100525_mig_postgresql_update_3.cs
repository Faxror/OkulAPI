using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OkulYönetimAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_postgresql_update_3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "examnotes",
                table: "Students",
                newName: "examnotestwo");

            migrationBuilder.RenameColumn(
                name: "examnotes",
                table: "HomeworkandExams",
                newName: "examnotetwo");

            migrationBuilder.AddColumn<string>(
                name: "examnotesone",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "examnotestfour",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "examnotesthree",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "examnotefour",
                table: "HomeworkandExams",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "examnotesone",
                table: "HomeworkandExams",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "examnotethree",
                table: "HomeworkandExams",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "examnotesone",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "examnotestfour",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "examnotesthree",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "examnotefour",
                table: "HomeworkandExams");

            migrationBuilder.DropColumn(
                name: "examnotesone",
                table: "HomeworkandExams");

            migrationBuilder.DropColumn(
                name: "examnotethree",
                table: "HomeworkandExams");

            migrationBuilder.RenameColumn(
                name: "examnotestwo",
                table: "Students",
                newName: "examnotes");

            migrationBuilder.RenameColumn(
                name: "examnotetwo",
                table: "HomeworkandExams",
                newName: "examnotes");
        }
    }
}

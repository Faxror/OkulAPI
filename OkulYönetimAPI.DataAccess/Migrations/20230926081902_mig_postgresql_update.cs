using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace OkulYönetimAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_postgresql_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "examnotes",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "homeworks",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Students",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HomeworkandExams",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    examnotes = table.Column<string>(type: "text", nullable: false),
                    homeworks = table.Column<string>(type: "text", nullable: false),
                    ıd = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeworkandExams", x => x.ID);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_HomeworkandExams_ID",
                table: "Students");

            migrationBuilder.DropTable(
                name: "HomeworkandExams");

            migrationBuilder.DropIndex(
                name: "IX_Students_ID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Students");

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
    }
}

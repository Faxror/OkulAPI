using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace OkulYönetimAPI.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig_postgresql_createdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    lessons = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    schoolname = table.Column<string>(type: "text", nullable: false),
                    schooladress = table.Column<string>(type: "text", nullable: false),
                    schoolphone = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    ıd = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    studentname = table.Column<string>(type: "text", nullable: false),
                    studentsurname = table.Column<string>(type: "text", nullable: false),
                    studentnumber = table.Column<string>(type: "text", nullable: false),
                    studentschool = table.Column<string>(type: "text", nullable: false),
                    aappointedteachers = table.Column<string>(type: "text", nullable: false),
                    studentsclassnumber = table.Column<string>(type: "text", nullable: false),
                    studentslevel = table.Column<string>(type: "text", nullable: false),
                    examnotes = table.Column<string>(type: "text", nullable: false),
                    homeworks = table.Column<string>(type: "text", nullable: false),
                    IdentıtyNumber = table.Column<int>(type: "integer", nullable: false),
                    StudentsPassword = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.ıd);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    teachername = table.Column<string>(type: "text", nullable: false),
                    teachersurname = table.Column<string>(type: "text", nullable: false),
                    teachernumber = table.Column<string>(type: "text", nullable: false),
                    teacheralan = table.Column<string>(type: "text", nullable: false),
                    teacherpermissions = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}

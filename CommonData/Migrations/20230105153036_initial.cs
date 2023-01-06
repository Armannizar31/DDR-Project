using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CommonData.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    studentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentFname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studentLname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studentAge = table.Column<int>(type: "int", nullable: false),
                    studentGender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studentClass = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.studentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}

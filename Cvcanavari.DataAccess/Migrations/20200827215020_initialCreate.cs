using Microsoft.EntityFrameworkCore.Migrations;

namespace Cvcanavari.DataAccess.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cvs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Adress = table.Column<string>(nullable: true),
                    AcademicHistory = table.Column<string>(nullable: true),
                    ProfessionalExperience = table.Column<string>(nullable: true),
                    Skills = table.Column<string>(nullable: true),
                    Awards = table.Column<string>(nullable: true),
                    Certifications = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cvs", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cvs");
        }
    }
}

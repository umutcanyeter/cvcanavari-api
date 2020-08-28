using Microsoft.EntityFrameworkCore.Migrations;

namespace Cvcanavari.DataAccess.Migrations
{
    public partial class cvTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcademicHistory",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "Awards",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "ProfessionalExperience",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "Skills",
                table: "Cvs");

            migrationBuilder.AddColumn<string>(
                name: "AcademicHistory1",
                table: "Cvs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AcademicHistory2",
                table: "Cvs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AcademicHistory3",
                table: "Cvs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Awards1",
                table: "Cvs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Awards2",
                table: "Cvs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Awards3",
                table: "Cvs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfessionalExperience1",
                table: "Cvs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfessionalExperience2",
                table: "Cvs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfessionalExperience3",
                table: "Cvs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Skills1",
                table: "Cvs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Skills2",
                table: "Cvs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Skills3",
                table: "Cvs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcademicHistory1",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "AcademicHistory2",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "AcademicHistory3",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "Awards1",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "Awards2",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "Awards3",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "ProfessionalExperience1",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "ProfessionalExperience2",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "ProfessionalExperience3",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "Skills1",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "Skills2",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "Skills3",
                table: "Cvs");

            migrationBuilder.AddColumn<string>(
                name: "AcademicHistory",
                table: "Cvs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Awards",
                table: "Cvs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfessionalExperience",
                table: "Cvs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Skills",
                table: "Cvs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

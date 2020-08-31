using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cvcanavari.DataAccess.Migrations
{
    public partial class jwtTablesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CvFileUrl",
                table: "Cvs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "Cvs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Github",
                table: "Cvs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Cvs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "Cvs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Linkedin",
                table: "Cvs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonelWebsite",
                table: "Cvs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Twitter",
                table: "Cvs",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    OperationClaimId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "CvFileUrl",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "Github",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "Linkedin",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "PersonelWebsite",
                table: "Cvs");

            migrationBuilder.DropColumn(
                name: "Twitter",
                table: "Cvs");
        }
    }
}

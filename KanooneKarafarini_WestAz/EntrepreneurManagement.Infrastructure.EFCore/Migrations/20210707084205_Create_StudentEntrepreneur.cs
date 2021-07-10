using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntrepreneurManagement.Infrastructure.EFCore.Migrations
{
    public partial class Create_StudentEntrepreneur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentEntrepreneur",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    StudentFamily = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    StudentNationalId = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    StudentBirthDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Education = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    StudentCity = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    StudentSchool = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    ParentFullname = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ParentNationalId = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ParentJob = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    StudentPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StudentMobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StudentAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentNationalCardPicture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentEntrepreneur", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentEntrepreneur");
        }
    }
}

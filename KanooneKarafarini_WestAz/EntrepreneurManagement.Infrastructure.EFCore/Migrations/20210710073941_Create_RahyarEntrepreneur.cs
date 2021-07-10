using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntrepreneurManagement.Infrastructure.EFCore.Migrations
{
    public partial class Create_RahyarEntrepreneur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RahyarEntrepreneur",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RahyarName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    RahyarFamily = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    RahyarNationalId = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    RahyarBirthDate = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    RahyarEducation = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    RahyarCourse = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    RahyarCity = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    RahyarPhone = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    RahyarMobile = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    RayharAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RahyarResume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RahyarEntrepreneur", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RahyarEntrepreneur");
        }
    }
}

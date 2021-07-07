using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntrepreneurManagement.Infrastructure.EFCore.Migrations
{
    public partial class Create_LegalEntrepreneur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LegalEntrepreneur",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    CompanyId = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ManagerName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ManagerFamily = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ManagerNationalId = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CompanySubject = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    CompanyCity = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyPhone = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CompanyMobile = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CompanyResume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalEntrepreneur", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LegalEntrepreneur");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntrepreneurManagement.Infrastructure.EFCore.Migrations
{
    public partial class Create_BenefactorEntrepreneur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BenefactorEntrepreneur",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BenefactorName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    BenefactorFamily = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    BenefactorNationalId = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    BenefactorJob = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BenefactorCooperation = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BenefactorPhone = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BenefactorMobile = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BenefactorAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CooperationDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenefactorEntrepreneur", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BenefactorEntrepreneur");
        }
    }
}

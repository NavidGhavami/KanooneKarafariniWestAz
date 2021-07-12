using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntrepreneurManagement.Infrastructure.EFCore.Migrations
{
    public partial class Create_SubmitIdea_In_EntrepreneurServices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubmitIdea",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicantName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ApplicantFamily = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ApplicantNationalId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProposalSubject = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    ApplicantPhone = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ApplicantMobile = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    ApplicantAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SummaryProposal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubmitIdea", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubmitIdea");
        }
    }
}

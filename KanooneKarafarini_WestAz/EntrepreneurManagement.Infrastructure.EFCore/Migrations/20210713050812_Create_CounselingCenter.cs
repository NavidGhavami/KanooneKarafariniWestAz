using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntrepreneurManagement.Infrastructure.EFCore.Migrations
{
    public partial class Create_CounselingCenter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CounselingCenter",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CouncelingCenterName = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    CouncelingCenterActivity = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    ManagerName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CouncelingCenterPhone = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CouncelingCenterMobile = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CouncelingCenterAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CounselingCenter", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CounselingCenter");
        }
    }
}

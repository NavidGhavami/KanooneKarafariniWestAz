using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntrepreneurManagement.Infrastructure.EFCore.Migrations
{
    public partial class Create_EntrepreneurCafe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EntrepreneurCafe",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CafeName = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    CafeCity = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: false),
                    CafeManager = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CafeLeader = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CafeManagerMobile = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CafeLeaderMobile = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntrepreneurCafe", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntrepreneurCafe");
        }
    }
}

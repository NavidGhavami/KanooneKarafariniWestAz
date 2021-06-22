using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImageGalleryManagement.EFCore.Migrations
{
    public partial class Create_Managers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    JobPosition = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    OrganizationType = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: false),
                    PictureAlt = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: false),
                    PictureTitle = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: false),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Managers");
        }
    }
}

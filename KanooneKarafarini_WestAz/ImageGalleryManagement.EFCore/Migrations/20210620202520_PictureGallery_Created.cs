﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ImageGalleryManagement.EFCore.Migrations
{
    public partial class PictureGallery_Created : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PictureGallery",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Picture = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    PictureAlt = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    PictureTitle = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PictureGallery", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PictureGallery");
        }
    }
}

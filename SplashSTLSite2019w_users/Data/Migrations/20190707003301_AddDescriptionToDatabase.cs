﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SplashSTLSite2019w_users.Data.Migrations
{
    public partial class AddDescriptionToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Locations",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Locations");
        }
    }
}

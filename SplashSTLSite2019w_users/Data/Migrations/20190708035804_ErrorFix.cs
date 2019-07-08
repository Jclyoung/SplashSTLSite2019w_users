using Microsoft.EntityFrameworkCore.Migrations;

namespace SplashSTLSite2019w_users.Data.Migrations
{
    public partial class ErrorFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocationRating_Locations_LocationId",
                table: "LocationRating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LocationRating",
                table: "LocationRating");

            migrationBuilder.RenameTable(
                name: "LocationRating",
                newName: "LocationRatings");

            migrationBuilder.RenameIndex(
                name: "IX_LocationRating_LocationId",
                table: "LocationRatings",
                newName: "IX_LocationRatings_LocationId");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Locations",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "Locations",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocationRatings",
                table: "LocationRatings",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LocationRatings_Locations_LocationId",
                table: "LocationRatings",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LocationRatings_Locations_LocationId",
                table: "LocationRatings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LocationRatings",
                table: "LocationRatings");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "Locations");

            migrationBuilder.RenameTable(
                name: "LocationRatings",
                newName: "LocationRating");

            migrationBuilder.RenameIndex(
                name: "IX_LocationRatings_LocationId",
                table: "LocationRating",
                newName: "IX_LocationRating_LocationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LocationRating",
                table: "LocationRating",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LocationRating_Locations_LocationId",
                table: "LocationRating",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieRentalApi.Migrations
{
    public partial class movies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MRAPPs",
                table: "MRAPPs");

            migrationBuilder.RenameTable(
                name: "MRAPPs",
                newName: "Movies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "MRAPPs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MRAPPs",
                table: "MRAPPs",
                column: "Id");
        }
    }
}

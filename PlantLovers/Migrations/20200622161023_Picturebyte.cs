using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantLovers.Migrations
{
    public partial class Picturebyte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Picture",
                table: "Flowers",
                newName: "pictureBinary");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "pictureBinary",
                table: "Flowers",
                newName: "Picture");
        }
    }
}

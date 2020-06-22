using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantLovers.Migrations
{
    public partial class Picture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PlantName",
                table: "Flowers",
                maxLength: 80,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PlantDescription",
                table: "Flowers",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                table: "Flowers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Flowers");

            migrationBuilder.AlterColumn<string>(
                name: "PlantName",
                table: "Flowers",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 80);

            migrationBuilder.AlterColumn<string>(
                name: "PlantDescription",
                table: "Flowers",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000);
        }
    }
}

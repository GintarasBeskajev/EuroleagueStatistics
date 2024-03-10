using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EuroleagueStatisticsBackend.Migrations
{
    /// <inheritdoc />
    public partial class FantasyStats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Teams",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Players",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(byte[]),
                oldType: "bytea",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Availability",
                table: "Players",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "BNFPoints",
                table: "Players",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FPoints",
                table: "Players",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "BNFPoints",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "FPoints",
                table: "Players");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Logo",
                table: "Teams",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Photo",
                table: "Players",
                type: "bytea",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}

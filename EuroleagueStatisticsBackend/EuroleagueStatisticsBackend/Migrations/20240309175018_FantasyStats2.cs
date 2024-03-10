using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EuroleagueStatisticsBackend.Migrations
{
    /// <inheritdoc />
    public partial class FantasyStats2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "BNFPoints",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "FPoints",
                table: "Teams");

            migrationBuilder.AddColumn<double>(
                name: "Availability",
                table: "PlayerRounds",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "BNFPoints",
                table: "PlayerRounds",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FPoints",
                table: "PlayerRounds",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "PlayerRounds");

            migrationBuilder.DropColumn(
                name: "BNFPoints",
                table: "PlayerRounds");

            migrationBuilder.DropColumn(
                name: "FPoints",
                table: "PlayerRounds");

            migrationBuilder.AddColumn<double>(
                name: "Availability",
                table: "Teams",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "BNFPoints",
                table: "Teams",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FPoints",
                table: "Teams",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}

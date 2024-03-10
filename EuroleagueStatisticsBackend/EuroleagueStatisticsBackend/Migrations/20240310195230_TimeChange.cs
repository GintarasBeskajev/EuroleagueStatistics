using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EuroleagueStatisticsBackend.Migrations
{
    /// <inheritdoc />
    public partial class TimeChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Minutes",
                table: "Teams",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "Minutes",
                table: "TeamRounds",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "Minutes",
                table: "Players",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "Minutes",
                table: "PlayerRounds",
                newName: "Time");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Teams",
                newName: "Minutes");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "TeamRounds",
                newName: "Minutes");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Players",
                newName: "Minutes");

            migrationBuilder.RenameColumn(
                name: "Time",
                table: "PlayerRounds",
                newName: "Minutes");
        }
    }
}

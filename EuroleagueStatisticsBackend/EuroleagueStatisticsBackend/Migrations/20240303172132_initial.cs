using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EuroleagueStatisticsBackend.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Abbreviation = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    Coach = table.Column<string>(type: "text", nullable: false),
                    Logo = table.Column<byte[]>(type: "bytea", nullable: true),
                    GamesPlayed = table.Column<int>(type: "integer", nullable: false),
                    Wins = table.Column<int>(type: "integer", nullable: false),
                    Losses = table.Column<int>(type: "integer", nullable: false),
                    Minutes = table.Column<double>(type: "double precision", nullable: false),
                    Fgm = table.Column<double>(type: "double precision", nullable: false),
                    Fga = table.Column<double>(type: "double precision", nullable: false),
                    Fg = table.Column<double>(type: "double precision", nullable: false),
                    Ftm = table.Column<double>(type: "double precision", nullable: false),
                    Fta = table.Column<double>(type: "double precision", nullable: false),
                    Ft = table.Column<double>(type: "double precision", nullable: false),
                    Points = table.Column<double>(type: "double precision", nullable: false),
                    ORebounds = table.Column<double>(type: "double precision", nullable: false),
                    DRebounds = table.Column<double>(type: "double precision", nullable: false),
                    Rebounds = table.Column<double>(type: "double precision", nullable: false),
                    Assists = table.Column<double>(type: "double precision", nullable: false),
                    Turnovers = table.Column<double>(type: "double precision", nullable: false),
                    Steals = table.Column<double>(type: "double precision", nullable: false),
                    Blocks = table.Column<double>(type: "double precision", nullable: false),
                    BlocksAllowed = table.Column<double>(type: "double precision", nullable: false),
                    PersonalFouls = table.Column<double>(type: "double precision", nullable: false),
                    PersonalFoulsDrawn = table.Column<double>(type: "double precision", nullable: false),
                    PlusMinus = table.Column<double>(type: "double precision", nullable: false),
                    ORating = table.Column<double>(type: "double precision", nullable: false),
                    DRating = table.Column<double>(type: "double precision", nullable: false),
                    NetRating = table.Column<double>(type: "double precision", nullable: false),
                    TrueShooting = table.Column<double>(type: "double precision", nullable: false),
                    Efficiency = table.Column<double>(type: "double precision", nullable: false),
                    Pace = table.Column<double>(type: "double precision", nullable: false),
                    Possesions = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    TeamId = table.Column<Guid>(type: "uuid", nullable: false),
                    Position = table.Column<string>(type: "text", nullable: false),
                    Photo = table.Column<byte[]>(type: "bytea", nullable: true),
                    GamesPlayed = table.Column<int>(type: "integer", nullable: false),
                    Wins = table.Column<int>(type: "integer", nullable: false),
                    Losses = table.Column<int>(type: "integer", nullable: false),
                    Minutes = table.Column<double>(type: "double precision", nullable: false),
                    Fgm = table.Column<double>(type: "double precision", nullable: false),
                    Fga = table.Column<double>(type: "double precision", nullable: false),
                    Fg = table.Column<double>(type: "double precision", nullable: false),
                    Ftm = table.Column<double>(type: "double precision", nullable: false),
                    Fta = table.Column<double>(type: "double precision", nullable: false),
                    Ft = table.Column<double>(type: "double precision", nullable: false),
                    Points = table.Column<double>(type: "double precision", nullable: false),
                    ORebounds = table.Column<double>(type: "double precision", nullable: false),
                    DRebounds = table.Column<double>(type: "double precision", nullable: false),
                    Rebounds = table.Column<double>(type: "double precision", nullable: false),
                    Assists = table.Column<double>(type: "double precision", nullable: false),
                    Turnovers = table.Column<double>(type: "double precision", nullable: false),
                    Steals = table.Column<double>(type: "double precision", nullable: false),
                    Blocks = table.Column<double>(type: "double precision", nullable: false),
                    BlocksAllowed = table.Column<double>(type: "double precision", nullable: false),
                    PersonalFouls = table.Column<double>(type: "double precision", nullable: false),
                    PersonalFoulsDrawn = table.Column<double>(type: "double precision", nullable: false),
                    PlusMinus = table.Column<double>(type: "double precision", nullable: false),
                    ORating = table.Column<double>(type: "double precision", nullable: false),
                    DRating = table.Column<double>(type: "double precision", nullable: false),
                    NetRating = table.Column<double>(type: "double precision", nullable: false),
                    TrueShooting = table.Column<double>(type: "double precision", nullable: false),
                    Efficiency = table.Column<double>(type: "double precision", nullable: false),
                    Pace = table.Column<double>(type: "double precision", nullable: false),
                    Possesions = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamRounds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Round = table.Column<int>(type: "integer", nullable: false),
                    TeamId = table.Column<Guid>(type: "uuid", nullable: false),
                    Minutes = table.Column<double>(type: "double precision", nullable: false),
                    Fgm = table.Column<double>(type: "double precision", nullable: false),
                    Fga = table.Column<double>(type: "double precision", nullable: false),
                    Fg = table.Column<double>(type: "double precision", nullable: false),
                    Ftm = table.Column<double>(type: "double precision", nullable: false),
                    Fta = table.Column<double>(type: "double precision", nullable: false),
                    Ft = table.Column<double>(type: "double precision", nullable: false),
                    Points = table.Column<double>(type: "double precision", nullable: false),
                    ORebounds = table.Column<double>(type: "double precision", nullable: false),
                    DRebounds = table.Column<double>(type: "double precision", nullable: false),
                    Rebounds = table.Column<double>(type: "double precision", nullable: false),
                    Assists = table.Column<double>(type: "double precision", nullable: false),
                    Turnovers = table.Column<double>(type: "double precision", nullable: false),
                    Steals = table.Column<double>(type: "double precision", nullable: false),
                    Blocks = table.Column<double>(type: "double precision", nullable: false),
                    BlocksAllowed = table.Column<double>(type: "double precision", nullable: false),
                    PersonalFouls = table.Column<double>(type: "double precision", nullable: false),
                    PersonalFoulsDrawn = table.Column<double>(type: "double precision", nullable: false),
                    PlusMinus = table.Column<double>(type: "double precision", nullable: false),
                    ORating = table.Column<double>(type: "double precision", nullable: false),
                    DRating = table.Column<double>(type: "double precision", nullable: false),
                    NetRating = table.Column<double>(type: "double precision", nullable: false),
                    TrueShooting = table.Column<double>(type: "double precision", nullable: false),
                    Efficiency = table.Column<double>(type: "double precision", nullable: false),
                    Pace = table.Column<double>(type: "double precision", nullable: false),
                    Possesions = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamRounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamRounds_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlayerRounds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Round = table.Column<int>(type: "integer", nullable: false),
                    PlayerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Minutes = table.Column<double>(type: "double precision", nullable: false),
                    Fgm = table.Column<double>(type: "double precision", nullable: false),
                    Fga = table.Column<double>(type: "double precision", nullable: false),
                    Fg = table.Column<double>(type: "double precision", nullable: false),
                    Ftm = table.Column<double>(type: "double precision", nullable: false),
                    Fta = table.Column<double>(type: "double precision", nullable: false),
                    Ft = table.Column<double>(type: "double precision", nullable: false),
                    Points = table.Column<double>(type: "double precision", nullable: false),
                    ORebounds = table.Column<double>(type: "double precision", nullable: false),
                    DRebounds = table.Column<double>(type: "double precision", nullable: false),
                    Rebounds = table.Column<double>(type: "double precision", nullable: false),
                    Assists = table.Column<double>(type: "double precision", nullable: false),
                    Turnovers = table.Column<double>(type: "double precision", nullable: false),
                    Steals = table.Column<double>(type: "double precision", nullable: false),
                    Blocks = table.Column<double>(type: "double precision", nullable: false),
                    BlocksAllowed = table.Column<double>(type: "double precision", nullable: false),
                    PersonalFouls = table.Column<double>(type: "double precision", nullable: false),
                    PersonalFoulsDrawn = table.Column<double>(type: "double precision", nullable: false),
                    PlusMinus = table.Column<double>(type: "double precision", nullable: false),
                    ORating = table.Column<double>(type: "double precision", nullable: false),
                    DRating = table.Column<double>(type: "double precision", nullable: false),
                    NetRating = table.Column<double>(type: "double precision", nullable: false),
                    TrueShooting = table.Column<double>(type: "double precision", nullable: false),
                    Efficiency = table.Column<double>(type: "double precision", nullable: false),
                    Pace = table.Column<double>(type: "double precision", nullable: false),
                    Possesions = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerRounds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerRounds_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerRounds_PlayerId",
                table: "PlayerRounds",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRounds_TeamId",
                table: "TeamRounds",
                column: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerRounds");

            migrationBuilder.DropTable(
                name: "TeamRounds");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}

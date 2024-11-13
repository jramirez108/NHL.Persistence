using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace NHL.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(type: "longtext", nullable: false),
                    Location = table.Column<string>(type: "longtext", nullable: false),
                    ConferenceId = table.Column<int>(type: "int", nullable: false),
                    ConferenceName = table.Column<string>(type: "longtext", nullable: false),
                    DivisionId = table.Column<int>(type: "int", nullable: false),
                    DivisionName = table.Column<string>(type: "longtext", nullable: false),
                    ShortName = table.Column<string>(type: "longtext", nullable: false),
                    FullName = table.Column<string>(type: "longtext", nullable: false),
                    ClubName = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    HomeTeamId = table.Column<int>(type: "int", nullable: false),
                    VisitorTeamId = table.Column<int>(type: "int", nullable: false),
                    GameDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HomeTeamOdds = table.Column<string>(type: "longtext", nullable: true),
                    VisitorTeamOdds = table.Column<string>(type: "longtext", nullable: true),
                    HomeTeamSpreadLine = table.Column<string>(type: "longtext", nullable: true),
                    HomeTeamSpreadOdds = table.Column<string>(type: "longtext", nullable: true),
                    VisitorTeamSpreadLine = table.Column<string>(type: "longtext", nullable: true),
                    VisitorTeamSpreadOdds = table.Column<string>(type: "longtext", nullable: true),
                    GameOverOdds = table.Column<string>(type: "longtext", nullable: true),
                    GameUnderOdds = table.Column<string>(type: "longtext", nullable: true),
                    GameRunLine = table.Column<float>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Games_Teams_HomeTeamId",
                        column: x => x.HomeTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_Teams_VisitorTeamId",
                        column: x => x.VisitorTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    JerseyNumber = table.Column<int>(type: "int", nullable: false),
                    PositionGroup = table.Column<string>(type: "longtext", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: false),
                    Hand = table.Column<string>(type: "longtext", nullable: false),
                    PositionAbbreviation = table.Column<string>(type: "longtext", nullable: false),
                    PositionName = table.Column<string>(type: "longtext", nullable: false),
                    FirstName = table.Column<string>(type: "longtext", nullable: false),
                    LastName = table.Column<string>(type: "longtext", nullable: false),
                    FullName = table.Column<string>(type: "longtext", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TeamStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    GoalsPG = table.Column<float>(type: "float", nullable: false),
                    GoalsPGRank = table.Column<int>(type: "int", nullable: false),
                    AssistsPG = table.Column<float>(type: "float", nullable: false),
                    AssistsPGRank = table.Column<int>(type: "int", nullable: false),
                    FaceoffsWonPG = table.Column<float>(type: "float", nullable: false),
                    FaceoffsPGRank = table.Column<int>(type: "int", nullable: false),
                    FaceoffsLostPG = table.Column<float>(type: "float", nullable: false),
                    FaceoffsLostRank = table.Column<int>(type: "int", nullable: false),
                    PointsPG = table.Column<float>(type: "float", nullable: false),
                    PointsPGRank = table.Column<int>(type: "int", nullable: false),
                    PPG = table.Column<float>(type: "float", nullable: false),
                    PPGRank = table.Column<int>(type: "int", nullable: false),
                    PPA = table.Column<float>(type: "float", nullable: false),
                    PPARank = table.Column<int>(type: "int", nullable: false),
                    SHG = table.Column<float>(type: "float", nullable: false),
                    SHGRank = table.Column<int>(type: "int", nullable: false),
                    SHA = table.Column<float>(type: "float", nullable: false),
                    SHARank = table.Column<int>(type: "int", nullable: false),
                    ShotsPG = table.Column<float>(type: "float", nullable: false),
                    ShotsRank = table.Column<int>(type: "int", nullable: false),
                    ShootingPct = table.Column<float>(type: "float", nullable: false),
                    ShootingRank = table.Column<int>(type: "int", nullable: false),
                    FaceoffPct = table.Column<float>(type: "float", nullable: false),
                    FaceoffRank = table.Column<int>(type: "int", nullable: false),
                    GoalsAgainstPG = table.Column<float>(type: "float", nullable: false),
                    GoalsAgainstPGRank = table.Column<int>(type: "int", nullable: false),
                    GoalsAgainst = table.Column<float>(type: "float", nullable: false),
                    GoalsAgainstRank = table.Column<int>(type: "int", nullable: false),
                    Saves = table.Column<float>(type: "float", nullable: false),
                    SavesRank = table.Column<int>(type: "int", nullable: false),
                    SavePct = table.Column<float>(type: "float", nullable: false),
                    SavePctRank = table.Column<int>(type: "int", nullable: false),
                    ShotsAgainst = table.Column<float>(type: "float", nullable: false),
                    ShotsAgainstRank = table.Column<int>(type: "int", nullable: false),
                    PenaltyMinutes = table.Column<float>(type: "float", nullable: false),
                    PenaltyMinutesRank = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamStats_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PlayerOdds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Line = table.Column<double>(type: "double", nullable: false),
                    Over = table.Column<string>(type: "longtext", nullable: false),
                    Under = table.Column<string>(type: "longtext", nullable: false),
                    Category = table.Column<string>(type: "longtext", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: true),
                    PlayerName = table.Column<string>(type: "longtext", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerOdds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerOdds_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PlayersStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    GameDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    Goals = table.Column<int>(type: "int", nullable: false),
                    Assists = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    PlusMinus = table.Column<int>(type: "int", nullable: false),
                    PenaltyMinutes = table.Column<int>(type: "int", nullable: false),
                    ShotsTotal = table.Column<int>(type: "int", nullable: false),
                    ShootingPct = table.Column<int>(type: "int", nullable: false),
                    PowerPlayGoals = table.Column<int>(type: "int", nullable: false),
                    PowerPlayAssists = table.Column<int>(type: "int", nullable: false),
                    ShortHandedGoals = table.Column<int>(type: "int", nullable: false),
                    ShortHandedAssists = table.Column<int>(type: "int", nullable: false),
                    GameWinningGoals = table.Column<int>(type: "int", nullable: false),
                    TimeOnIcePerGame = table.Column<int>(type: "int", nullable: false),
                    Production = table.Column<int>(type: "int", nullable: false),
                    IsHomeGame = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsWin = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PlayersParticipated = table.Column<string>(type: "longtext", nullable: false),
                    OpposingTeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayersStats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayersStats_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayersStats_Teams_OpposingTeamId",
                        column: x => x.OpposingTeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Games_HomeTeamId",
                table: "Games",
                column: "HomeTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_VisitorTeamId",
                table: "Games",
                column: "VisitorTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerOdds_PlayerId",
                table: "PlayerOdds",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayersStats_OpposingTeamId",
                table: "PlayersStats",
                column: "OpposingTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayersStats_PlayerId",
                table: "PlayersStats",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamStats_TeamId",
                table: "TeamStats",
                column: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "PlayerOdds");

            migrationBuilder.DropTable(
                name: "PlayersStats");

            migrationBuilder.DropTable(
                name: "TeamStats");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}

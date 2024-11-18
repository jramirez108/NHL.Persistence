using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NHL.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdatesToStats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AssistsPG",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "AssistsPGRank",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "FaceoffPct",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "FaceoffRank",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "FaceoffsLostPG",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "FaceoffsLostRank",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "FaceoffsPGRank",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "FaceoffsWonPG",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "GoalsAgainst",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "GoalsAgainstPG",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "GoalsAgainstPGRank",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "GoalsAgainstRank",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "GoalsPG",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "GoalsPGRank",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "PPA",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "PPARank",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "PPG",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "PPGRank",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "PenaltyMinutes",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "PenaltyMinutesRank",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "PointsPG",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "PointsPGRank",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "SHA",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "SHARank",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "SHG",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "SHGRank",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "SavePct",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "SavePctRank",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "Saves",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "SavesRank",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "ShootingPct",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "ShootingRank",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "ShotsAgainstRank",
                table: "TeamStats");
            migrationBuilder.DropColumn(
                name: "ShotsRank",
                table: "TeamStats");
            migrationBuilder.DropColumn(
                name: "ShotsPG",
                table: "TeamStats");
            migrationBuilder.DropColumn(
                name: "ShotsAgainst",
                table: "TeamStats");

            migrationBuilder.AddColumn<int>(
                name: "Rank",
                table: "TeamStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Value",
                table: "TeamStats",
                type: "float",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "PerGameValue",
                table: "TeamStats",
                type: "float",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "TeamStats",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "TeamStats",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "ShortName",
                table: "TeamStats",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "GoalsAgainst",
                table: "PlayersStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Saves",
                table: "PlayersStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShotsAgainst",
                table: "PlayersStats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "ShortName",
                table: "TeamStats");

            migrationBuilder.DropColumn(
                name: "GoalsAgainst",
                table: "PlayersStats");

            migrationBuilder.DropColumn(
                name: "Saves",
                table: "PlayersStats");

            migrationBuilder.DropColumn(
                name: "ShotsAgainst",
                table: "PlayersStats");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "TeamStats",
                newName: "ShotsPG");

            migrationBuilder.RenameColumn(
                name: "Rank",
                table: "TeamStats",
                newName: "ShotsRank");

            migrationBuilder.RenameColumn(
                name: "PerGameValue",
                table: "TeamStats",
                newName: "ShotsAgainst");

            migrationBuilder.AddColumn<float>(
                name: "AssistsPG",
                table: "TeamStats",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "AssistsPGRank",
                table: "TeamStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "FaceoffPct",
                table: "TeamStats",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "FaceoffRank",
                table: "TeamStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "FaceoffsLostPG",
                table: "TeamStats",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "FaceoffsLostRank",
                table: "TeamStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FaceoffsPGRank",
                table: "TeamStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "FaceoffsWonPG",
                table: "TeamStats",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GoalsAgainst",
                table: "TeamStats",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "GoalsAgainstPG",
                table: "TeamStats",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "GoalsAgainstPGRank",
                table: "TeamStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GoalsAgainstRank",
                table: "TeamStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "GoalsPG",
                table: "TeamStats",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "GoalsPGRank",
                table: "TeamStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "PPA",
                table: "TeamStats",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "PPARank",
                table: "TeamStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "PPG",
                table: "TeamStats",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "PPGRank",
                table: "TeamStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "PenaltyMinutes",
                table: "TeamStats",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PenaltyMinutesRank",
                table: "TeamStats",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "PointsPG",
                table: "TeamStats",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "PointsPGRank",
                table: "TeamStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "SHA",
                table: "TeamStats",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "SHARank",
                table: "TeamStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "SHG",
                table: "TeamStats",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "SHGRank",
                table: "TeamStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "SavePct",
                table: "TeamStats",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "SavePctRank",
                table: "TeamStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Saves",
                table: "TeamStats",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "SavesRank",
                table: "TeamStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "ShootingPct",
                table: "TeamStats",
                type: "float",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "ShootingRank",
                table: "TeamStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShotsAgainstRank",
                table: "TeamStats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

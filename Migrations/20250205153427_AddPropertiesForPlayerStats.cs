using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NHL.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddPropertiesForPlayerStats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlockedShots",
                table: "PlayersStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "EventStregthTimeOnIce",
                table: "PlayersStats",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "FaceOffLost",
                table: "PlayersStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FaceOffsWon",
                table: "PlayersStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GiveAways",
                table: "PlayersStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Hits",
                table: "PlayersStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MissedShots",
                table: "PlayersStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfPenalties",
                table: "PlayersStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PowerPlayTimeOnIce",
                table: "PlayersStats",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "ShootoutGoals",
                table: "PlayersStats",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ShortHandedTimeOneIce",
                table: "PlayersStats",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "TakeAways",
                table: "PlayersStats",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BlockedShots",
                table: "PlayersStats");

            migrationBuilder.DropColumn(
                name: "EventStregthTimeOnIce",
                table: "PlayersStats");

            migrationBuilder.DropColumn(
                name: "FaceOffLost",
                table: "PlayersStats");

            migrationBuilder.DropColumn(
                name: "FaceOffsWon",
                table: "PlayersStats");

            migrationBuilder.DropColumn(
                name: "GiveAways",
                table: "PlayersStats");

            migrationBuilder.DropColumn(
                name: "Hits",
                table: "PlayersStats");

            migrationBuilder.DropColumn(
                name: "MissedShots",
                table: "PlayersStats");

            migrationBuilder.DropColumn(
                name: "NumberOfPenalties",
                table: "PlayersStats");

            migrationBuilder.DropColumn(
                name: "PowerPlayTimeOnIce",
                table: "PlayersStats");

            migrationBuilder.DropColumn(
                name: "ShootoutGoals",
                table: "PlayersStats");

            migrationBuilder.DropColumn(
                name: "ShortHandedTimeOneIce",
                table: "PlayersStats");

            migrationBuilder.DropColumn(
                name: "TakeAways",
                table: "PlayersStats");
        }
    }
}

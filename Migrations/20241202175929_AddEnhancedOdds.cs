using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace NHL.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddEnhancedOdds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "EnhancedNBAPlayerOdds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Line = table.Column<double>(type: "double", nullable: false),
                    Category = table.Column<string>(type: "longtext", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    PlayerName = table.Column<string>(type: "longtext", nullable: false),
                    Markets = table.Column<string>(type: "longtext", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnhancedNBAPlayerOdds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnhancedNBAPlayerOdds_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_EnhancedNBAPlayerOdds_PlayerId",
                table: "EnhancedNBAPlayerOdds",
                column: "PlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnhancedNBAPlayerOdds");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerOdds_PlayerId",
                table: "PlayerOdds",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerOdds_Players_PlayerId",
                table: "PlayerOdds",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

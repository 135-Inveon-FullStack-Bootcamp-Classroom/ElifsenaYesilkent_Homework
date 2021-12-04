using Microsoft.EntityFrameworkCore.Migrations;

namespace week_7_FootballManager.Migrations
{
    public partial class FootballerAddedTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FootballerPosition");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FootballerPosition",
                columns: table => new
                {
                    FootballersId = table.Column<int>(type: "int", nullable: false),
                    PositionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballerPosition", x => new { x.FootballersId, x.PositionsId });
                    table.ForeignKey(
                        name: "FK_FootballerPosition_Footballers_FootballersId",
                        column: x => x.FootballersId,
                        principalTable: "Footballers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballerPosition_Positions_PositionsId",
                        column: x => x.PositionsId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FootballerPosition_PositionsId",
                table: "FootballerPosition",
                column: "PositionsId");
        }
    }
}

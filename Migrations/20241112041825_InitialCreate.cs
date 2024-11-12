using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TampaPremierLeague.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tpleague",
                columns: table => new
                {
                    Position = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Played = table.Column<int>(type: "int", nullable: false),
                    Won = table.Column<int>(type: "int", nullable: false),
                    Lost = table.Column<int>(type: "int", nullable: false),
                    NoResult = table.Column<int>(type: "int", nullable: false),
                    NetRunRate = table.Column<double>(type: "float", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    RecentForm = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tpleague", x => x.Position);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tpleague");
        }
    }
}

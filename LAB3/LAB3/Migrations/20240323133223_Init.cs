using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAB3.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BazaPogodowa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    country = table.Column<string>(type: "TEXT", nullable: false),
                    temp = table.Column<float>(type: "REAL", nullable: false),
                    humidity = table.Column<float>(type: "REAL", nullable: false),
                    temp_min = table.Column<float>(type: "REAL", nullable: false),
                    temp_max = table.Column<float>(type: "REAL", nullable: false),
                    lon = table.Column<float>(type: "REAL", nullable: false),
                    lat = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BazaPogodowa", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BazaPogodowa");
        }
    }
}

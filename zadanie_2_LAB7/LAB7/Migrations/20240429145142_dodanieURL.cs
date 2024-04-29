using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAB7.Migrations
{
    /// <inheritdoc />
    public partial class dodanieURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "photoURL",
                table: "DataMovie",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "photoURL",
                table: "DataMovie");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAB7.Migrations
{
    /// <inheritdoc />
    public partial class dodanieDaty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "DataRating",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "DataRating");
        }
    }
}

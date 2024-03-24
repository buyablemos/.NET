using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAB3.Migrations
{
    /// <inheritdoc />
    public partial class addedDateFilter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "aktualnaDataCzas",
                table: "BazaPogodowa",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "aktualnaDataCzas",
                table: "BazaPogodowa");
        }
    }
}

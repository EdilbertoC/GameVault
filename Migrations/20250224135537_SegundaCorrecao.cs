using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameVault.Migrations
{
    /// <inheritdoc />
    public partial class SegundaCorrecao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TempoDeJogo",
                table: "Reviews");

            migrationBuilder.AddColumn<int>(
                name: "HorasDeJogo",
                table: "Reviews",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HorasDeJogo",
                table: "Reviews");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "TempoDeJogo",
                table: "Reviews",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }
    }
}

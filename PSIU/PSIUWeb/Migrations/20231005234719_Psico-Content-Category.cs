using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSIUWeb.Migrations
{
    public partial class PsicoContentCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Psicos_AspNetUsers_UserId",
                table: "Psicos");

            migrationBuilder.DropIndex(
                name: "IX_Psicos_UserId",
                table: "Psicos");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Psicos");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "Psicos");

            migrationBuilder.DropColumn(
                name: "Race",
                table: "Psicos");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Psicos");

            migrationBuilder.AlterColumn<string>(
                name: "Crp",
                table: "Psicos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "Liberado",
                table: "Psicos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Liberado",
                table: "Psicos");

            migrationBuilder.AlterColumn<int>(
                name: "Crp",
                table: "Psicos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Psicos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Cep",
                table: "Psicos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Race",
                table: "Psicos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Psicos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Psicos_UserId",
                table: "Psicos",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Psicos_AspNetUsers_UserId",
                table: "Psicos",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}

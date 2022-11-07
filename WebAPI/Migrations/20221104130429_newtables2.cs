using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class newtables2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JoinTeamRequest_User_JoinTeamRequestProperty",
                table: "JoinTeamRequest");

            migrationBuilder.DropIndex(
                name: "IX_JoinTeamRequest_JoinTeamRequestProperty",
                table: "JoinTeamRequest");

            migrationBuilder.DropColumn(
                name: "JoinTeamRequestProperty",
                table: "JoinTeamRequest");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JoinTeamRequestProperty",
                table: "JoinTeamRequest",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JoinTeamRequest_JoinTeamRequestProperty",
                table: "JoinTeamRequest",
                column: "JoinTeamRequestProperty");

            migrationBuilder.AddForeignKey(
                name: "FK_JoinTeamRequest_User_JoinTeamRequestProperty",
                table: "JoinTeamRequest",
                column: "JoinTeamRequestProperty",
                principalTable: "User",
                principalColumn: "id");
        }
    }
}

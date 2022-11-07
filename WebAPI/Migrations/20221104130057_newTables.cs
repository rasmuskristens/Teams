using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class newTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Role_RoleProperty",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_RoleProperty",
                table: "User");

            migrationBuilder.DropColumn(
                name: "RoleProperty",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Role",
                newName: "Id");

            migrationBuilder.AddColumn<bool>(
                name: "isAdministrator",
                table: "User",
                type: "bit",
                maxLength: 50,
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "JoinTeamRequest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateRequested = table.Column<DateTime>(type: "datetime2", unicode: false, nullable: false),
                    TeamMembershipId = table.Column<int>(type: "int", nullable: false),
                    Reviewed = table.Column<bool>(type: "bit", unicode: false, maxLength: 50, nullable: false),
                    Approved = table.Column<bool>(type: "bit", unicode: false, maxLength: 50, nullable: false),
                    UserProperty = table.Column<int>(type: "int", nullable: false),
                    ReviewedDate = table.Column<DateTime>(type: "datetime2", unicode: false, nullable: false),
                    JoinTeamRequestProperty = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinTeamRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JoinTeamRequest_User_JoinTeamRequestProperty",
                        column: x => x.JoinTeamRequestProperty,
                        principalTable: "User",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_JoinTeamRequest_User_UserProperty",
                        column: x => x.UserProperty,
                        principalTable: "User",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DepartmentID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Team_Membership",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", unicode: false, maxLength: 50, nullable: false),
                    RoleId = table.Column<int>(type: "int", unicode: false, maxLength: 50, nullable: false),
                    isActive = table.Column<bool>(type: "bit", unicode: false, maxLength: 50, nullable: false),
                    DepartmentProperty = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team_Membership", x => new { x.UserId, x.TeamId });
                    table.ForeignKey(
                        name: "FK_Team_Membership_Team_DepartmentProperty",
                        column: x => x.DepartmentProperty,
                        principalTable: "Team",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_JoinTeamRequest_JoinTeamRequestProperty",
                table: "JoinTeamRequest",
                column: "JoinTeamRequestProperty");

            migrationBuilder.CreateIndex(
                name: "IX_JoinTeamRequest_UserProperty",
                table: "JoinTeamRequest",
                column: "UserProperty");

            migrationBuilder.CreateIndex(
                name: "IX_Team_Membership_DepartmentProperty",
                table: "Team_Membership",
                column: "DepartmentProperty");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JoinTeamRequest");

            migrationBuilder.DropTable(
                name: "Team_Membership");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropColumn(
                name: "isAdministrator",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Role",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "RoleProperty",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleProperty",
                table: "User",
                column: "RoleProperty");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Role_RoleProperty",
                table: "User",
                column: "RoleProperty",
                principalTable: "Role",
                principalColumn: "id");
        }
    }
}

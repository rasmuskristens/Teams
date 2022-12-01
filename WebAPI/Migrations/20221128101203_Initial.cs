using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPI.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activity_Occurrence",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    ActivityOccuranceId = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PollId = table.Column<int>(type: "int", nullable: false),
                    DiscussionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity_Occurrence", x => new { x.TeamId, x.ActivityOccuranceId });
                });

            migrationBuilder.CreateTable(
                name: "Custom_Discussion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    TopicText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Custom_Discussion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Custom_Poll",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PollOptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Custom_Poll", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Poll_Vote",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ActivityOccuranceId = table.Column<int>(type: "int", unicode: false, maxLength: 50, nullable: false),
                    VoteOptionNumber = table.Column<int>(type: "int", unicode: false, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poll_Vote", x => new { x.UserId, x.ActivityOccuranceId });
                });

            migrationBuilder.CreateTable(
                name: "Sociolite_Team",
                columns: table => new
                {
                    TeamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MSTeamsTeamId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    MSTeamsChannelId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recurring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sociolite_Team", x => x.TeamId);
                });

            migrationBuilder.CreateTable(
                name: "Sociolite_Team_Membership",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", unicode: false, maxLength: 50, nullable: false),
                    TeamSpecificRole = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sociolite_Team_Membership", x => new { x.UserId, x.TeamId });
                });

            migrationBuilder.CreateTable(
                name: "Sociolite_User",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sociolite_User", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activity_Occurrence");

            migrationBuilder.DropTable(
                name: "Custom_Discussion");

            migrationBuilder.DropTable(
                name: "Custom_Poll");

            migrationBuilder.DropTable(
                name: "Poll_Vote");

            migrationBuilder.DropTable(
                name: "Sociolite_Team");

            migrationBuilder.DropTable(
                name: "Sociolite_Team_Membership");

            migrationBuilder.DropTable(
                name: "Sociolite_User");
        }
    }
}

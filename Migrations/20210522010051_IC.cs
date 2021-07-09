using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TennisAustraliaAssignment.Migrations
{
    public partial class IC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgeBracket",
                columns: table => new
                {
                    AgeBracketID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgeBracketName = table.Column<string>(maxLength: 50, nullable: false),
                    AgeBracketDescription = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeBracket", x => x.AgeBracketID);
                });

            migrationBuilder.CreateTable(
                name: "LeagueRatings",
                columns: table => new
                {
                    LeagueID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeagueName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeagueRatings", x => x.LeagueID);
                });

            migrationBuilder.CreateTable(
                name: "PersonalDetails",
                columns: table => new
                {
                    PersonalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 30, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Street = table.Column<string>(maxLength: 100, nullable: false),
                    City = table.Column<string>(maxLength: 100, nullable: false),
                    Postcode = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: true),
                    TennisMembershipNumber = table.Column<int>(nullable: true),
                    AustralianRanking = table.Column<int>(nullable: true),
                    UniversalTennisRating = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDetails", x => x.PersonalID);
                });

            migrationBuilder.CreateTable(
                name: "registrations",
                columns: table => new
                {
                    RegistrationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationSignDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registrations", x => x.RegistrationID);
                });

            migrationBuilder.CreateTable(
                name: "Surface",
                columns: table => new
                {
                    SurfaceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurfaceName = table.Column<string>(maxLength: 100, nullable: false),
                    SurfaceDescription = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surface", x => x.SurfaceID);
                });

            migrationBuilder.CreateTable(
                name: "TournamentTypes",
                columns: table => new
                {
                    TournamentTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentTypeName = table.Column<string>(maxLength: 100, nullable: false),
                    TournamentTypeDescription = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentTypes", x => x.TournamentTypeID);
                });

            migrationBuilder.CreateTable(
                name: "RegistrationDetails",
                columns: table => new
                {
                    RegistrationDetailsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationID = table.Column<int>(nullable: false),
                    PlayerPersonalID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationDetails", x => x.RegistrationDetailsID);
                    table.ForeignKey(
                        name: "FK_RegistrationDetails_PersonalDetails_PlayerPersonalID",
                        column: x => x.PlayerPersonalID,
                        principalTable: "PersonalDetails",
                        principalColumn: "PersonalID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegistrationDetails_registrations_RegistrationID",
                        column: x => x.RegistrationID,
                        principalTable: "registrations",
                        principalColumn: "RegistrationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Venue",
                columns: table => new
                {
                    VenueID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VenueName = table.Column<string>(maxLength: 100, nullable: false),
                    Street = table.Column<string>(maxLength: 100, nullable: false),
                    City = table.Column<string>(maxLength: 60, nullable: false),
                    State = table.Column<string>(maxLength: 4, nullable: false),
                    SurfaceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venue", x => x.VenueID);
                    table.ForeignKey(
                        name: "FK_Venue_Surface_SurfaceID",
                        column: x => x.SurfaceID,
                        principalTable: "Surface",
                        principalColumn: "SurfaceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    TournamentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentName = table.Column<string>(maxLength: 100, nullable: false),
                    Qualifier = table.Column<string>(maxLength: 3, nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    SingupStartDate = table.Column<DateTime>(nullable: false),
                    SingupEndDate = table.Column<DateTime>(nullable: false),
                    PrizeMoney = table.Column<int>(nullable: false),
                    VenueID = table.Column<int>(nullable: false),
                    TournamentTypeID = table.Column<int>(nullable: false),
                    OrganiserPersonalID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.TournamentID);
                    table.ForeignKey(
                        name: "FK_Tournaments_PersonalDetails_OrganiserPersonalID",
                        column: x => x.OrganiserPersonalID,
                        principalTable: "PersonalDetails",
                        principalColumn: "PersonalID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tournaments_TournamentTypes_TournamentTypeID",
                        column: x => x.TournamentTypeID,
                        principalTable: "TournamentTypes",
                        principalColumn: "TournamentTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tournaments_Venue_VenueID",
                        column: x => x.VenueID,
                        principalTable: "Venue",
                        principalColumn: "VenueID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TournamentBrackets",
                columns: table => new
                {
                    TournamentBracketID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentID = table.Column<int>(nullable: false),
                    AgeBracketID = table.Column<int>(nullable: false),
                    LeagueRatingLeagueID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentBrackets", x => x.TournamentBracketID);
                    table.ForeignKey(
                        name: "FK_TournamentBrackets_AgeBracket_AgeBracketID",
                        column: x => x.AgeBracketID,
                        principalTable: "AgeBracket",
                        principalColumn: "AgeBracketID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TournamentBrackets_LeagueRatings_LeagueRatingLeagueID",
                        column: x => x.LeagueRatingLeagueID,
                        principalTable: "LeagueRatings",
                        principalColumn: "LeagueID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TournamentBrackets_Tournaments_TournamentID",
                        column: x => x.TournamentID,
                        principalTable: "Tournaments",
                        principalColumn: "TournamentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    MatchID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Round = table.Column<int>(nullable: false),
                    TournamentBracketID = table.Column<int>(nullable: false),
                    FirstRegistrationID = table.Column<int>(nullable: false),
                    SecondRegistrationID = table.Column<int>(nullable: false),
                    RegistrationDetailsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchID);
                    table.ForeignKey(
                        name: "FK_Matches_RegistrationDetails_RegistrationDetailsID",
                        column: x => x.RegistrationDetailsID,
                        principalTable: "RegistrationDetails",
                        principalColumn: "RegistrationDetailsID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_TournamentBrackets_TournamentBracketID",
                        column: x => x.TournamentBracketID,
                        principalTable: "TournamentBrackets",
                        principalColumn: "TournamentBracketID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinaleResults",
                columns: table => new
                {
                    FinaleResultID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchID = table.Column<int>(nullable: false),
                    WinRegistrationID = table.Column<int>(nullable: false),
                    WinRegistrationFinaleScore = table.Column<int>(nullable: false),
                    SecondRegistrationID = table.Column<int>(nullable: false),
                    SecondPlayerScore = table.Column<int>(nullable: false),
                    RegistrationID = table.Column<int>(nullable: true),
                    SetsPlayed = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinaleResults", x => x.FinaleResultID);
                    table.ForeignKey(
                        name: "FK_FinaleResults_Matches_MatchID",
                        column: x => x.MatchID,
                        principalTable: "Matches",
                        principalColumn: "MatchID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FinaleResults_registrations_RegistrationID",
                        column: x => x.RegistrationID,
                        principalTable: "registrations",
                        principalColumn: "RegistrationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "setResults",
                columns: table => new
                {
                    SetResultID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    set = table.Column<int>(nullable: false),
                    FirstRegIDScore = table.Column<int>(nullable: false),
                    SecondRegIDScore = table.Column<int>(nullable: false),
                    MatchID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_setResults", x => x.SetResultID);
                    table.ForeignKey(
                        name: "FK_setResults_Matches_MatchID",
                        column: x => x.MatchID,
                        principalTable: "Matches",
                        principalColumn: "MatchID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FinaleResults_MatchID",
                table: "FinaleResults",
                column: "MatchID");

            migrationBuilder.CreateIndex(
                name: "IX_FinaleResults_RegistrationID",
                table: "FinaleResults",
                column: "RegistrationID");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_RegistrationDetailsID",
                table: "Matches",
                column: "RegistrationDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TournamentBracketID",
                table: "Matches",
                column: "TournamentBracketID");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationDetails_PlayerPersonalID",
                table: "RegistrationDetails",
                column: "PlayerPersonalID");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationDetails_RegistrationID",
                table: "RegistrationDetails",
                column: "RegistrationID");

            migrationBuilder.CreateIndex(
                name: "IX_setResults_MatchID",
                table: "setResults",
                column: "MatchID");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentBrackets_AgeBracketID",
                table: "TournamentBrackets",
                column: "AgeBracketID");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentBrackets_LeagueRatingLeagueID",
                table: "TournamentBrackets",
                column: "LeagueRatingLeagueID");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentBrackets_TournamentID",
                table: "TournamentBrackets",
                column: "TournamentID");

            migrationBuilder.CreateIndex(
                name: "IX_Tournaments_OrganiserPersonalID",
                table: "Tournaments",
                column: "OrganiserPersonalID");

            migrationBuilder.CreateIndex(
                name: "IX_Tournaments_TournamentTypeID",
                table: "Tournaments",
                column: "TournamentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tournaments_VenueID",
                table: "Tournaments",
                column: "VenueID");

            migrationBuilder.CreateIndex(
                name: "IX_Venue_SurfaceID",
                table: "Venue",
                column: "SurfaceID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FinaleResults");

            migrationBuilder.DropTable(
                name: "setResults");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "RegistrationDetails");

            migrationBuilder.DropTable(
                name: "TournamentBrackets");

            migrationBuilder.DropTable(
                name: "registrations");

            migrationBuilder.DropTable(
                name: "AgeBracket");

            migrationBuilder.DropTable(
                name: "LeagueRatings");

            migrationBuilder.DropTable(
                name: "Tournaments");

            migrationBuilder.DropTable(
                name: "PersonalDetails");

            migrationBuilder.DropTable(
                name: "TournamentTypes");

            migrationBuilder.DropTable(
                name: "Venue");

            migrationBuilder.DropTable(
                name: "Surface");
        }
    }
}

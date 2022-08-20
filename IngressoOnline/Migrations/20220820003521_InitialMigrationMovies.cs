using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace IngressoOnline.Migrations
{
    public partial class InitialMigrationMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "actors",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ActorName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actors", x => x.ActorId);
                });

            migrationBuilder.CreateTable(
                name: "directors",
                columns: table => new
                {
                    DirectorId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DirectorName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_directors", x => x.DirectorId);
                });

            migrationBuilder.CreateTable(
                name: "movieCategories",
                columns: table => new
                {
                    MovieCategoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MovieCategoryType = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieCategories", x => x.MovieCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "movieRatings",
                columns: table => new
                {
                    MovieRatingId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MovieRatingClassification = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movieRatings", x => x.MovieRatingId);
                });

            migrationBuilder.CreateTable(
                name: "publishers",
                columns: table => new
                {
                    PublisherId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PublisherName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publishers", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    Movieid = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MovieTitle = table.Column<string>(type: "text", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MovieRatingId = table.Column<int>(type: "integer", nullable: true),
                    MovieCategoryId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.Movieid);
                    table.ForeignKey(
                        name: "FK_movies_movieCategories_MovieCategoryId",
                        column: x => x.MovieCategoryId,
                        principalTable: "movieCategories",
                        principalColumn: "MovieCategoryId");
                    table.ForeignKey(
                        name: "FK_movies_movieRatings_MovieRatingId",
                        column: x => x.MovieRatingId,
                        principalTable: "movieRatings",
                        principalColumn: "MovieRatingId");
                });

            migrationBuilder.CreateTable(
                name: "actorMovies",
                columns: table => new
                {
                    ActorMovieId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ActorId = table.Column<int>(type: "integer", nullable: true),
                    Movieid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_actorMovies", x => x.ActorMovieId);
                    table.ForeignKey(
                        name: "FK_actorMovies_actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "actors",
                        principalColumn: "ActorId");
                    table.ForeignKey(
                        name: "FK_actorMovies_movies_Movieid",
                        column: x => x.Movieid,
                        principalTable: "movies",
                        principalColumn: "Movieid");
                });

            migrationBuilder.CreateTable(
                name: "directorMovies",
                columns: table => new
                {
                    DirectorMovieId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DirectorId = table.Column<int>(type: "integer", nullable: true),
                    Movieid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_directorMovies", x => x.DirectorMovieId);
                    table.ForeignKey(
                        name: "FK_directorMovies_directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "directors",
                        principalColumn: "DirectorId");
                    table.ForeignKey(
                        name: "FK_directorMovies_movies_Movieid",
                        column: x => x.Movieid,
                        principalTable: "movies",
                        principalColumn: "Movieid");
                });

            migrationBuilder.CreateTable(
                name: "publisherMovies",
                columns: table => new
                {
                    PublisherMovieId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Movieid = table.Column<int>(type: "integer", nullable: true),
                    PublisherId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_publisherMovies", x => x.PublisherMovieId);
                    table.ForeignKey(
                        name: "FK_publisherMovies_movies_Movieid",
                        column: x => x.Movieid,
                        principalTable: "movies",
                        principalColumn: "Movieid");
                    table.ForeignKey(
                        name: "FK_publisherMovies_publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "publishers",
                        principalColumn: "PublisherId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_actorMovies_ActorId",
                table: "actorMovies",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_actorMovies_Movieid",
                table: "actorMovies",
                column: "Movieid");

            migrationBuilder.CreateIndex(
                name: "IX_directorMovies_DirectorId",
                table: "directorMovies",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_directorMovies_Movieid",
                table: "directorMovies",
                column: "Movieid");

            migrationBuilder.CreateIndex(
                name: "IX_movies_MovieCategoryId",
                table: "movies",
                column: "MovieCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_movies_MovieRatingId",
                table: "movies",
                column: "MovieRatingId");

            migrationBuilder.CreateIndex(
                name: "IX_publisherMovies_Movieid",
                table: "publisherMovies",
                column: "Movieid");

            migrationBuilder.CreateIndex(
                name: "IX_publisherMovies_PublisherId",
                table: "publisherMovies",
                column: "PublisherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "actorMovies");

            migrationBuilder.DropTable(
                name: "directorMovies");

            migrationBuilder.DropTable(
                name: "publisherMovies");

            migrationBuilder.DropTable(
                name: "actors");

            migrationBuilder.DropTable(
                name: "directors");

            migrationBuilder.DropTable(
                name: "movies");

            migrationBuilder.DropTable(
                name: "publishers");

            migrationBuilder.DropTable(
                name: "movieCategories");

            migrationBuilder.DropTable(
                name: "movieRatings");
        }
    }
}

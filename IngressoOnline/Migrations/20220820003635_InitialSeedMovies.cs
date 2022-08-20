using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IngressoOnline.Migrations
{
    public partial class InitialSeedMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("actors", "ActorName", "Chris Hemsworth");
            migrationBuilder.InsertData("actors", "ActorName", "Robert Downey Jr.");
            migrationBuilder.InsertData("actors", "ActorName", "Chris Evans");
            migrationBuilder.InsertData("actors", "ActorName", "Christan Bale");
            migrationBuilder.InsertData("actors", "ActorName", "Mark Rufalo");
            migrationBuilder.InsertData("actors", "ActorName", "Jhonny Depp");
            migrationBuilder.InsertData("actors", "ActorName", "Ryan Reynolds");
            migrationBuilder.InsertData("actors", "ActorName", "James McAvoy");
            migrationBuilder.InsertData("actors", "ActorName", "Hugh Jackman");
            migrationBuilder.InsertData("actors", "ActorName", "Henry Cavil");

            migrationBuilder.InsertData("directors", "DirectorName", "Peter Jackson");
            migrationBuilder.InsertData("directors", "DirectorName", "Peter Jackson 1");
            migrationBuilder.InsertData("directors", "DirectorName", "Peter Jackson 2");
            migrationBuilder.InsertData("directors", "DirectorName", "Peter Jackson 3");
            migrationBuilder.InsertData("directors", "DirectorName", "Peter Jackson 4");
            migrationBuilder.InsertData("directors", "DirectorName", "Peter Jackson 5");
            migrationBuilder.InsertData("directors", "DirectorName", "Peter Jackson 6");

            migrationBuilder.InsertData("publishers", "PublisherName", "Marvel");
            migrationBuilder.InsertData("publishers", "PublisherName", "DC");
            migrationBuilder.InsertData("publishers", "PublisherName", "Warner");
            migrationBuilder.InsertData("publishers", "PublisherName", "Disney");
            migrationBuilder.InsertData("publishers", "PublisherName", "Marvel 1");
            migrationBuilder.InsertData("publishers", "PublisherName", "Marvel 2");
            migrationBuilder.InsertData("publishers", "PublisherName", "Marvel 3");
            migrationBuilder.InsertData("publishers", "PublisherName", "Marvel 4");

            migrationBuilder.InsertData("movieCategories", "MovieCategoryType", "Drama");
            migrationBuilder.InsertData("movieCategories", "MovieCategoryType", "Terror");
            migrationBuilder.InsertData("movieCategories", "MovieCategoryType", "Ação");
            migrationBuilder.InsertData("movieCategories", "MovieCategoryType", "Suspense");
            migrationBuilder.InsertData("movieCategories", "MovieCategoryType", "Aventura");

            migrationBuilder.InsertData("movieRatings", "MovieRatingClassification", "Livre");
            migrationBuilder.InsertData("movieRatings", "MovieRatingClassification", "Menores de 10 anos");
            migrationBuilder.InsertData("movieRatings", "MovieRatingClassification", "Menores de 14 anos");
            migrationBuilder.InsertData("movieRatings", "MovieRatingClassification", "Menores de 16 anos");
            migrationBuilder.InsertData("movieRatings", "MovieRatingClassification", "Maiores de 18 anos");


            migrationBuilder.InsertData("movies", columns: new[] { "MovieTitle", "ReleaseDate", "MovieRatingId", "MovieCategoryId"}, 
                values: new object[] { "Teste 1",DateTime.UtcNow, 1,2 });
            migrationBuilder.InsertData("movies", columns: new[] { "MovieTitle", "ReleaseDate", "MovieRatingId", "MovieCategoryId" },
                values: new object[] { "Teste 2", DateTime.UtcNow, 2, 2 });
            migrationBuilder.InsertData("movies", columns: new[] { "MovieTitle", "ReleaseDate", "MovieRatingId", "MovieCategoryId" },
                values: new object[] { "Teste 3", DateTime.UtcNow, 1, 2 });
            migrationBuilder.InsertData("movies", columns: new[] { "MovieTitle", "ReleaseDate", "MovieRatingId", "MovieCategoryId" },
                values: new object[] { "Teste 4", DateTime.UtcNow, 3, 3 });
            migrationBuilder.InsertData("movies", columns: new[] { "MovieTitle", "ReleaseDate", "MovieRatingId", "MovieCategoryId" },
                values: new object[] { "Teste 5", DateTime.UtcNow, 2, 4 });
            migrationBuilder.InsertData("movies", columns: new[] { "MovieTitle", "ReleaseDate", "MovieRatingId", "MovieCategoryId" },
                values: new object[] { "Teste 6", DateTime.UtcNow, 3, 3 });
            migrationBuilder.InsertData("movies", columns: new[] { "MovieTitle", "ReleaseDate", "MovieRatingId", "MovieCategoryId" },
                values: new object[] { "Teste 7", DateTime.UtcNow, 4, 2 });
            migrationBuilder.InsertData("movies", columns: new[] { "MovieTitle", "ReleaseDate", "MovieRatingId", "MovieCategoryId" },
                values: new object[] { "Teste 8", DateTime.UtcNow, 5, 2 });
            migrationBuilder.InsertData("movies", columns: new[] { "MovieTitle", "ReleaseDate", "MovieRatingId", "MovieCategoryId" },
                values: new object[] { "Teste 9", DateTime.UtcNow, 2, 2 });


            migrationBuilder.InsertData("actorMovies", columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 1, 1});
            migrationBuilder.InsertData("actorMovies", columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 2, 1 });
            migrationBuilder.InsertData("actorMovies", columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 3, 1 });
            migrationBuilder.InsertData("actorMovies", columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 4, 1 });
            migrationBuilder.InsertData("actorMovies", columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 1, 2 });
            migrationBuilder.InsertData("actorMovies", columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 1, 3 });
            migrationBuilder.InsertData("actorMovies", columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 1, 4 });
            migrationBuilder.InsertData("actorMovies", columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 1, 5 });
            migrationBuilder.InsertData("actorMovies", columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 1, 6 });

            migrationBuilder.InsertData("publisherMovies", columns: new[] { "PublisherId", "MovieId" },
                values: new object[] { 1, 1 });
            migrationBuilder.InsertData("publisherMovies", columns: new[] { "PublisherId", "MovieId" },
                values: new object[] { 1, 2 });
            migrationBuilder.InsertData("publisherMovies", columns: new[] { "PublisherId", "MovieId" },
                values: new object[] { 1, 3 });
            migrationBuilder.InsertData("publisherMovies", columns: new[] { "PublisherId", "MovieId" },
                values: new object[] { 1, 4 });
            migrationBuilder.InsertData("publisherMovies", columns: new[] { "PublisherId", "MovieId" },
                values: new object[] { 1, 5 });
            migrationBuilder.InsertData("publisherMovies", columns: new[] { "PublisherId", "MovieId" },
                values: new object[] { 2, 6 });
            migrationBuilder.InsertData("publisherMovies", columns: new[] { "PublisherId", "MovieId" },
                values: new object[] { 2, 1 });
            migrationBuilder.InsertData("publisherMovies", columns: new[] { "PublisherId", "MovieId" },
                values: new object[] { 3, 1 });


            migrationBuilder.InsertData("directorMovies", columns: new[] { "DirectorId", "MovieId" },
                values: new object[] { 1, 6 });

            migrationBuilder.InsertData("directorMovies", columns: new[] { "DirectorId", "MovieId" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData("directorMovies", columns: new[] { "DirectorId", "MovieId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData("directorMovies", columns: new[] { "DirectorId", "MovieId" },
                values: new object[] { 1, 3 });
            migrationBuilder.InsertData("directorMovies", columns: new[] { "DirectorId", "MovieId" },
                values: new object[] { 1, 2 });
            migrationBuilder.InsertData("directorMovies", columns: new[] { "DirectorId", "MovieId" },
                values: new object[] { 2, 2 });
            migrationBuilder.InsertData("directorMovies", columns: new[] { "DirectorId", "MovieId" },
                values: new object[] { 2, 1 });





        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

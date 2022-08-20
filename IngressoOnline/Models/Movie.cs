namespace IngressoOnline.Models
{
    public class Movie
    {
        public int Movieid { get; set; }

        public string? MovieTitle { get; set; }

        public DateTime ReleaseDate { get; set; }

        public virtual MovieRating? MovieRating { get; set; }

        public virtual MovieCategory? MovieCategory { get; set; }

        public List<ActorMovie>? actorMovies { get; set; }
        public List<DirectorMovie>? directorMovies { get; set; }
        public List<PublisherMovie>? publisherMovies { get; set; }


    }
}

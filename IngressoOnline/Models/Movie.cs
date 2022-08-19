namespace IngressoOnline.Models
{
    public class Movie
    {
        public int Movieid { get; set; }

        public string? MovieTitle { get; set; }

        public DateTime ReleaseDate { get; set; }

        public virtual MovieRating? MovieRating { get; set; }

        public virtual MovieCategory? MovieCategory { get; set; }

        public virtual List<Publisher>? Publishers { get; set; }

        public virtual List<Actor>? Actors { get; set; }

        public virtual List<Director>? Directors { get; set; }
    }
}

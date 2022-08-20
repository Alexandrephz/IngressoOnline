namespace IngressoOnline.Models
{
    public class Director
    {
        public int DirectorId { get; set; }
        public string? DirectorName { get; set; }

        public List<DirectorMovie>? directorMovies { get; set; }
    }
}

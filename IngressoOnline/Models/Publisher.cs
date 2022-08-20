namespace IngressoOnline.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        public string? PublisherName { get; set; }

        public List<PublisherMovie>? publisherMovies { get; set; }
    }
}

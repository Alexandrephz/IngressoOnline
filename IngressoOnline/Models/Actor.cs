namespace IngressoOnline.Models
{
    public class Actor
    {
        public int ActorId { get; set; }
        public string? ActorName { get; set; }

        public List<ActorMovie>? ActorMovies { get; set; }
    }
}

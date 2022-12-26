namespace eTickets.Models
{
    public class Actors_Movies
    {
        //Actor
        public int ActorId { get; set; }
        public Actor Actor { get; set; }    

        //Movie
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

    }
}

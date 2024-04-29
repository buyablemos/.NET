namespace LAB7.Components
{
    public class Rating
    {
        public int Id { get; set; }

        public int? MovieId { get; set; }

        public Movie Movie { get; set; } = null!;
        public float? Value { get; set; }

        public string? User { get; set; }

        public DateTime? Date { get; set; }

        /*
        public Rating(int id, float value, string user, Movie movie)
        {
            this.Id = id;
            this.Value = value;
            this.User = user;
            this.Movie = movie;
            this.MovieId=movie.Id;
        }*/

    }
}

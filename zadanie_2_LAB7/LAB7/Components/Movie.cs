using System.ComponentModel.DataAnnotations;

namespace LAB7.Components
{
    public class Movie
    {

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public string? photoURL { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? RelaseDate { get; set; }

        public ICollection<Rating>? Ratings { get; } = new List<Rating>();

    }
}

using System;
namespace ApplicationCore.Entities
{
    public class Trailer
    {
        public int Id { get; set; }
        public string TrailerUrl { get; set; }
        public string Name { get; set; }

        //navigation propeties, to get infor in Movie
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}

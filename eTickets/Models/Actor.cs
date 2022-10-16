using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL{ get; set; }
        public int FullName { get; set; }
        public int Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies{ get; set; }
    }
}

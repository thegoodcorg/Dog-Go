using System.Collections.Generic;

namespace DogGo.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public int NeighborhoodId { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<Neighborhood> Neighborhoods { get; set; } = new List<Neighborhood>();
        public List<Dog> Dogs { get; set; } = new List<Dog>();
    }
}

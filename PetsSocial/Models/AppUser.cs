using System.ComponentModel.DataAnnotations;

namespace PetsSocial.Models
{
    public class AppUser
    {
        [Key]
        public string Id { get; set; }
        public int NumOfPets { get; set; }
        public string Gender { get; set; }
        public Address? Address { get; set; }

        public ICollection<Pet> Pets { get; set; }
        public ICollection<Meetup> Meetups { get; set; }
    }
}

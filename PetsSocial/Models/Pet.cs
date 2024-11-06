using PetsSocial.Data.ENum;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetsSocial.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image {  get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }    
        public PetType PetType { get; set; }
        [ForeignKey("AppUser")]
        public string? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}

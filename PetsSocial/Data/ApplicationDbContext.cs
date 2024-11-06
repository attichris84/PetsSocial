using Microsoft.EntityFrameworkCore;
using PetsSocial.Models;

namespace PetsSocial.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Meetup> Meetups { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}

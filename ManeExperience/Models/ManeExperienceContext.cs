using Microsoft.EntityFrameworkCore;
using ManeExperience.Models;

namespace ManeExperience.Models
{
    public class ManeExperienceContext : DbContext
    {
        public ManeExperienceContext (DbContextOptions<ManeExperienceContext> options) : base(options)
        {

        }
        public DbSet<ManeExperience.Models.Event> Event {get; set;}
        public DbSet<ManeExperience.Models.User> User { get; set; }
    }
}
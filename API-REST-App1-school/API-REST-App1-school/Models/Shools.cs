using Microsoft.EntityFrameworkCore;

namespace API_REST_App1_school.Models
{
    public class Shools: DbContext
    { 
        public Shools(DbContextOptions<Shools> option)
            : base(option)
        {

        }

        public DbSet<Course> Courses { get; set; }
    }
}

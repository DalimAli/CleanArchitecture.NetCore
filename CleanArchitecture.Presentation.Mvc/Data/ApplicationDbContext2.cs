using CleanArchitecture.Domain;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Presentation.Mvc.Data
{
    public class ApplicationDbContext2 : DbContext
    {
        public ApplicationDbContext2(DbContextOptions options) : base(options)
        {

        } 

        public DbSet<Course> Courses { get; set; }
    }
}

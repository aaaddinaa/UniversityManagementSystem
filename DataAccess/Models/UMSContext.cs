using Microsoft.EntityFrameworkCore;

namespace DataAccess.Models
{
    public class UMSContext : DbContext
    {
        public UMSContext() : base()
        {

        }

        public UMSContext(DbContextOptions<UMSContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}

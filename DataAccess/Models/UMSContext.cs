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
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<CourseTeacher> CourseTeachers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseTeacher>()
                .HasKey(tc => new { tc.TeacherID, tc.CourseID });    

        }
    }
}

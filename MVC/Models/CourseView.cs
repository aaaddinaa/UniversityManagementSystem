using System.Collections.Generic;

namespace MVC.Models
{
    public class CourseView :BaseEntity
    {
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<EnrollmentView> Enrollments { get; set; }
        public virtual ICollection<CourseTeacherView> CourseTeachers { get; set; }
    }
}

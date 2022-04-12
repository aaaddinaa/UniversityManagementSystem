using System.Collections.Generic;

namespace UMS.Models
{
    public class CourseView :BaseEntity
    {
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<EnrollmentView> Enrollments { get; set; }
        public virtual ICollection<CourseTeacherView> CourseTeachers { get; set; }
    }
}

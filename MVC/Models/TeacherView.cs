using System;
using System.Collections.Generic;

namespace MVC.Models
{
    public class TeacherView : BaseEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime HireDate { get; set; }

        public virtual ICollection<CourseTeacherView> CourseTeachers { get; set; }
        public virtual OfficeView Office { get; set; }
    }
}

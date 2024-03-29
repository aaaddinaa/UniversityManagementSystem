﻿using System.Collections.Generic;

namespace DataAccess.Models
{
    public class Course : BaseEntity 
    {
        public string Title { get; set; }
        public int Credits { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public virtual ICollection<CourseTeacher> CourseTeachers { get; set; }
        

    }
}

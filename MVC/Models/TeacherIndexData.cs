﻿using System.Collections.Generic;

namespace MVC.Models
{
    public class TeacherIndexData
    {
        public IEnumerable<TeacherView> Teachers { get; set; }
        public IEnumerable<CourseView> Courses { get; set; }
        public IEnumerable<EnrollmentView> Enrollments { get; set; }
    }
}

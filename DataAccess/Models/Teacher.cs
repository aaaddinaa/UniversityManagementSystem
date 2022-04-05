using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public class Teacher : BaseEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime HireDate { get; set; }

        public virtual ICollection<CourseTeacher> CourseTeachers{ get; set; }
        public virtual Office Office { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DataAccess.Models
{
    public class Student : BaseEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}

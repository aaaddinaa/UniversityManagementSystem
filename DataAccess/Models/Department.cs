using System.Collections.Generic;


namespace DataAccess.Models
{
    public class Department 
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }

        public int? TeacherID { get; set; }

        public virtual Teacher Admin { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC.Models
{
    public class TeacherView : BaseEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime HireDate { get; set; }

        public virtual ICollection<CourseTeacherView> CourseTeachers { get; set; }
        public virtual OfficeView Office { get; set; }
    }
}

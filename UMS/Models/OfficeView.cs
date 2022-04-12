using System.ComponentModel.DataAnnotations;

namespace UMS.Models
{
    public class OfficeView : BaseEntity
    {
        //[ForeignKey("Teacher")]
        [Display(Name = "Assigned teacher")]
        public int TeacherID { get; set; }
        public string Location { get; set; }

        public virtual TeacherView Teacher { get; set; }
    }
}

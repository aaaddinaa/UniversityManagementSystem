namespace MVC.Models
{
    public class OfficeView : BaseEntity
    {
        //[ForeignKey("Teacher")]
        public int TeacherID { get; set; }
        public string Location { get; set; }

        public virtual TeacherView Teacher { get; set; }
    }
}

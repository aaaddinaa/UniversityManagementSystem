namespace MVC.Models
{
    public class CourseTeacherView : BaseEntity
    {
        public int CourseID { get; set; }
        public int TeacherID { get; set; }

        public virtual CourseView Course { get; set; }
        public virtual TeacherView Teacher { get; set; }
    }
}

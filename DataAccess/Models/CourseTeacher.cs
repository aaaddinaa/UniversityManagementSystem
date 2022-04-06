namespace DataAccess.Models
{
    public class CourseTeacher : BaseEntity
    {
        public int CourseID { get; set; }
        public int TeacherID { get; set; }

        public virtual Course Course { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}

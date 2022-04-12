namespace UMS.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class EnrollmentView :BaseEntity
    {
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public virtual CourseView Course { get; set; }
        public virtual StudentView Student { get; set; }
    }
}

﻿namespace DataAccess.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment : BaseEntity
    {
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}

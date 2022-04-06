using System.ComponentModel.DataAnnotations.Schema;


namespace DataAccess.Models
{
    public class Office : BaseEntity
    {
        [ForeignKey("Teacher")]
        public int TeacherID { get; set; }
        public string Location { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}

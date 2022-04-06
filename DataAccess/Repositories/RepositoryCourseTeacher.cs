using DataAccess.Models;

namespace DataAccess.Repositories
{
    public class RepositoryCourseTeacher : Repository<CourseTeacher>, IRepository<CourseTeacher>
    {
        public RepositoryCourseTeacher(UMSContext context) : base(context)
        {

        }
    }
}

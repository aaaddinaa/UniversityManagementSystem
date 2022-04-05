using DataAccess.Models;

namespace DataAccess.Repositories
{
    public class RepositoryCourse : Repository<Course>, IRepository<Course>
    {
        public RepositoryCourse(UMSContext context) : base(context)
        {

        }
    }
}

using DataAccess.Models;

namespace DataAccess.Repositories
{
    public class RepositoryEnrollment : Repository<Enrollment>, IRepository<Enrollment>
    {
        public RepositoryEnrollment(UMSContext context) : base(context)
        {

        }
    }
}

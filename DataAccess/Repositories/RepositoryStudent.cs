using DataAccess.Models;

namespace DataAccess.Repositories
{
    public class RepositoryStudent : Repository<Student>, IRepository<Student>
    {
        public RepositoryStudent(UMSContext context) : base(context)
        {

        }
    }
}

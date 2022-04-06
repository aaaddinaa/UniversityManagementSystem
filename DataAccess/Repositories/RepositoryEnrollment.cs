using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class RepositoryEnrollment : Repository<Enrollment>, IRepository<Enrollment>
    {
        public RepositoryEnrollment(UMSContext context) : base(context)
        {

        }

        public override async Task<List<Enrollment>> GetAllAsync()
        {
            return await _context.Enrollments.Include(c => c.Course)
                                             .Include(s => s.Student).ToListAsync();
        }
    }
}

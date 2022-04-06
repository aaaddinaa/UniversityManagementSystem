using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class RepositoryTeacher : Repository<Teacher>, IRepository<Teacher>
    {
        public RepositoryTeacher(UMSContext context) : base(context)
        {

        }

        public override async Task<List<Teacher>> GetAllAsync()
        {
            return await _context.Teachers.Include(o => o.Office).ToListAsync();
        }
    }
}

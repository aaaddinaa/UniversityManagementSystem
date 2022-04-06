using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class RepositoryOffice : Repository<Office>, IRepository<Office>
    {
        public RepositoryOffice(UMSContext context) : base(context)
        {

        }

        public override async Task<List<Office>> GetAllAsync()
        {
            return await _context.Offices.Include(t => t.Teacher).ToListAsync();
        }
    }
}

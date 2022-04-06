using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class RepositoryCourseTeacher : Repository<CourseTeacher>, IRepository<CourseTeacher>
    {
        public RepositoryCourseTeacher(UMSContext context) : base(context)
        {

        }

        public override async Task<List<CourseTeacher>> GetAllAsync()
        {
            return await _context.CourseTeachers.Include(c => c.Course)
                                                .Include(t => t.Teacher).ToListAsync();
        }
    }
}

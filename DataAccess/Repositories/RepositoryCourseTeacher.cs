using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class RepositoryCourseTeacher : Repository<CourseTeacher>, IRepository<CourseTeacher>
    {
        public RepositoryCourseTeacher(UMSContext context) : base(context)
        {

        }
    }
}

using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface ICourseService
    {
        Task<List<Course>> GetAll();
        Task<Course> GetById(int id);
        Task<Course> Add(Course course);
        Task<Course> Update(Course course);
        Task<bool> Delete(int id);
    }
}

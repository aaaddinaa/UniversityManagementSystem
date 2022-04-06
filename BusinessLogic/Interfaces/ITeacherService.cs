using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface ITeacherService
    {
        Task<List<Teacher>> GetAll();
        Task<Teacher> GetById(int id);
        Task<Teacher> Add(Teacher teacher);
        Task<Teacher> Update(Teacher teacher);
        Task<bool> Delete(int id);
    }
}

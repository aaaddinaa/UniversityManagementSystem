using DataAccess.Models;    
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IStudentService
    {
        Task<List<Student>> GetAll();
        Task<Student> GetById(int id);
        Task<Student> Add(Student student);
        Task<Student> Update(Student student);
        Task<bool> Delete(int id);
    }
}

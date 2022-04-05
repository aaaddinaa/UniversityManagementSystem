using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IEnrollmentService
    {
        Task<List<Enrollment>> GetAll();
        Task<Enrollment> GetById(int id);
        Task<Enrollment> Add(Enrollment enrollment);
        Task<Enrollment> Update(Enrollment enrollment);
        Task<bool> Delete(int id);
    }
}

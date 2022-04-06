using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IOfficeService
    {
        Task<List<Office>> GetAll();
        Task<Office> GetById(int id);
        Task<Office> Add(Office office);
        Task<Office> Update(Office office);
        Task<bool> Delete(int id);
    }
}

using BusinessLogic.Interfaces;
using DataAccess.Models;
using DataAccess.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public class OfficeService : IOfficeService
    {
        protected readonly IRepository<Office> _repository;

        public OfficeService(IRepository<Office> repository)
        {
            _repository = repository;
        }

        public async Task<Office> Add(Office office)
        {
            return await _repository.AddAsync(office);
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<Office>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Office> GetById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Office> Update(Office office)
        {
            return await _repository.UpdateAsync(office);
        }
    }
}

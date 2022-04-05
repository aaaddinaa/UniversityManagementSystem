using BusinessLogic.Interfaces;
using DataAccess.Models;
using DataAccess.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public class EnrollmentService : IEnrollmentService
    {
        protected readonly IRepository<Enrollment> _repository;

        public EnrollmentService(IRepository<Enrollment> repository)
        {
            _repository = repository;           
        }
        public async Task<Enrollment> Add(Enrollment enrollment)
        {
            return await _repository.AddAsync(enrollment);
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<Enrollment>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Enrollment> GetById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Enrollment> Update(Enrollment enrollment)
        {
            return await _repository.UpdateAsync(enrollment);
        }
    }
}

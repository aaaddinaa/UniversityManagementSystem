using BusinessLogic.Interfaces;
using DataAccess.Models;
using DataAccess.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public class TeacherService : ITeacherService
    {
        protected readonly IRepository<Teacher> _repository;

        public TeacherService(IRepository<Teacher> repository)
        {
            _repository = repository;
        }
        public async Task<Teacher> Add(Teacher teacher)
        {
            return await _repository.AddAsync(teacher);
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<Teacher>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Teacher> GetById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Teacher> Update(Teacher teacher)
        {
            return await _repository.UpdateAsync(teacher);
        }
    }
}

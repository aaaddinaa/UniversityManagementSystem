using BusinessLogic.Interfaces;
using DataAccess.Models;
using DataAccess.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public class StudentService : IStudentService
    {
        protected readonly IRepository<Student> _repository;

        public StudentService(IRepository<Student> repository)
        {
            _repository = repository;
        }
        public async Task<Student> Add(Student student)
        {
            return await _repository.AddAsync(student);
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<Student>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Student> GetById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Student> Update(Student student)
        {
            return await _repository.UpdateAsync(student);
        }
    }
}

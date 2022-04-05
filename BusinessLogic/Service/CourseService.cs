using BusinessLogic.Interfaces;
using DataAccess.Models;
using DataAccess.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public class CourseService : ICourseService
    {
        protected readonly IRepository<Course> _repository;

        public CourseService(IRepository<Course> repository)
        {
            _repository = repository;
        }
        public async Task<Course> Add(Course course)
        {
            return await _repository.AddAsync(course);
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<Course>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Course> GetById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Course> Update(Course course)
        {
            return await _repository.UpdateAsync(course);
        }
    }
}

using BusinessLogic.Interfaces;
using DataAccess.Models;
using DataAccess.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Service
{
    public class CourseTeacherService : ICourseTeacherService
    {
        protected readonly IRepository<CourseTeacher> _repository;

        public CourseTeacherService(IRepository<CourseTeacher> repository)
        {
            _repository = repository;
        }

        public async Task<CourseTeacher> Add(CourseTeacher courseTeacher)
        {
            return await _repository.AddAsync(courseTeacher);
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<CourseTeacher>> GetAll()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<CourseTeacher> GetById(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<CourseTeacher> Update(CourseTeacher courseTeacher)
        {
            return await _repository.UpdateAsync(courseTeacher);
        }
    }
}

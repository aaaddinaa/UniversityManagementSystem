using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface ICourseTeacherService
    {
        Task<List<CourseTeacher>> GetAll();
        Task<CourseTeacher> GetById(int id);
        Task<CourseTeacher> Add(CourseTeacher courseTeacher);
        Task<CourseTeacher> Update(CourseTeacher courseTeacher);
        Task<bool> Delete(int id);
    }
}

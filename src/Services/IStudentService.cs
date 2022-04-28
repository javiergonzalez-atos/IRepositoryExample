using EFAndLinqPractice_SchoolAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFAndLinqPractice_SchoolAPI.Services
{
    public interface IStudentService
    {
        Task<Student> Create(Student student);
        Task<Student> GetById(int id);
        Task<IEnumerable<Student>> GetAll();
        Task<IEnumerable<Student>> GetStudentsByCourseId(int courseId);
    }
}
using EFAndLinqPractice_SchoolAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFAndLinqPractice_SchoolAPI.Repositories
{
    public interface IStudentRepository
    {
        Task<Student> AddStudent(Student student);
        Task<Student> GetById(int id);
        Task<IEnumerable<Student>> GetAll();
        Task<IEnumerable<Student>> GetStudentsByCourseId(int courseId);
        Task<Student> Update(int id, Student student);
    }
}
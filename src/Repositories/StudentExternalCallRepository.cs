using EFAndLinqPractice_SchoolAPI.ExternalAPIs;
using EFAndLinqPractice_SchoolAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFAndLinqPractice_SchoolAPI.Repositories
{
    public class StudentExternalCallRepository : IStudentRepository
    {
        private readonly ExternalSchoolHttpClient _externalApi;

        public StudentExternalCallRepository(ExternalSchoolHttpClient externalApi)
        {
            _externalApi = externalApi;
        }
        
        public async Task<Student> AddStudent(Student student)
        {
            return await _externalApi.AddStudent(student);
        }

        public async Task<Student> GetById(int id)
        {
            return await _externalApi.GetStudentById(id);
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _externalApi.GetAll();
        }

        public async Task<IEnumerable<Student>> GetStudentsByCourseId(int courseId)
        {
            return await _externalApi.GetStudentsByCourseId(courseId);
        }

        public async Task<Student> Update(int id, Student student)
        {
            return await _externalApi.UpdateStudent(id, student);
        }
    }
}
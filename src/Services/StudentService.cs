using EFAndLinqPractice_SchoolAPI.Repositories;
using EFAndLinqPractice_SchoolAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFAndLinqPractice_SchoolAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<Student> Create(Student student)
        {
            return await _studentRepository.AddStudent(student);
        }

        public async Task<Student> GetById(int id)
        {
            return await _studentRepository.GetById(id);
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _studentRepository.GetAll();
        }

        public async Task<IEnumerable<Student>> GetStudentsByCourseId(int courseId)
        {
            return await _studentRepository.GetStudentsByCourseId(courseId);
        }

        public async Task<Student> Update(int id, Student student)
        {
            return await _studentRepository.Update(id, student);
        }
    }
}
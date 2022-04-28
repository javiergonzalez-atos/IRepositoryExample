using EFAndLinqPractice_SchoolAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EFAndLinqPractice_SchoolAPI.Repositories
{
    public class StudentEntityFrameworkRepository : IStudentRepository
    {
        private readonly SchoolContext _dbContext;

        public StudentEntityFrameworkRepository(SchoolContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<Student> AddStudent(Student student)
        {
            _dbContext.Add(student);
            await _dbContext.SaveChangesAsync();

            return student;
        }

        public async Task<Student> GetById(int id)
        {
            var student = await _dbContext.Students.FirstOrDefaultAsync(s => s.Id == id);

            return student;
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            var students = await _dbContext.Students.ToListAsync();//.Include(c => c.Courses ).ToList();

            return students;
        }

        public async Task<IEnumerable<Student>> GetStudentsByCourseId(int courseId)
        {
            var courseStudents = await _dbContext.Students
                .Where(s => s.Courses.Any(c => c.Id == courseId)).ToListAsync();

            return courseStudents;
        }

        public async Task<Student> Update(int id, Student student)
        {
            var studentToUpdate = await _dbContext.Students.FirstOrDefaultAsync(s => s.Id == id);

            if (studentToUpdate is null)
            {
                return null;
            }

            studentToUpdate.Courses = student.Courses;
            studentToUpdate.Height = student.Height;
            studentToUpdate.Weight = student.Weight;
            studentToUpdate.Name = student.Name;

            _dbContext.SaveChanges();

            return studentToUpdate;
        }
    }
}
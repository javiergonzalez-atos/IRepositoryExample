using System.Threading.Tasks;
using EFAndLinqPractice_SchoolAPI.Services;
using EFAndLinqPractice_SchoolAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFAndLinqPractice_SchoolAPI.Controllers
{
    [ApiController]
    [Route("api/students/")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await _studentService.GetAll();
            
            return Ok(students);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetStudent(int id)
        {
            var student = await _studentService.GetById(id);
            
            return Ok(student);
        }
        
        [HttpGet("course/{courseId:int}")]
        public async Task<IActionResult> GetStudentsByCourseId(int courseId)
        {
            var students = await _studentService.GetStudentsByCourseId(courseId);
            
            return Ok(students);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent(Student student)
        {
            var createdStudent = await _studentService.Create(student);
            
            return CreatedAtAction(nameof(GetStudent), new { id = createdStudent.Id}, student);
        }
    }
}
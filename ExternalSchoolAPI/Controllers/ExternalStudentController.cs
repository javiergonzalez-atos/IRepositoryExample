using System;
using System.Collections.Generic;
using ExternalSchoolAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExternalSchoolAPI.Controllers
{
    [Route("external-api/students/")]
    [ApiController]
    public class ExternalStudentController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public ActionResult<Student> GetById(int id)
        {
            var student = new Student
            {
                Id = 1,
                Name = "Carlos Vela",
                Birthday = new DateTime(1989, 3, 1),
                Height = 1.77f,
                Weight = 70,
                Courses = null
            };

            return student;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAll()
        {
            var students = new List<Student>()
            {
                new Student()
                {
                    Id = 1,
                    Name = "Carlos Vela",
                    Birthday = new DateTime(1989, 3, 1),
                    Height = 1.77f,
                    Weight = 70,
                    Courses = null
                },
                new Student
                {
                    Id = 2,
                    Name = "Lewis Hamilton",
                    Birthday = new DateTime(1985, 1, 7),
                    Height = 1.74f,
                    Weight = 73,
                    Courses = null
                }
            };
            return students;
        }

        [HttpGet("course/{courseId}")]
        public ActionResult<IEnumerable<Student>> GetStudentsByCourseId(int courseId)
        {
            var students = new List<Student>()
            {
                new Student
                {
                    Id = 2,
                    Name = "Lewis Hamilton",
                    Birthday = new DateTime(1985, 1, 7),
                    Height = 1.74f,
                    Weight = 73,
                    Courses = null
                }
            };
            
            return students;
        }
        
        [HttpPost("add")]
        public ActionResult<Student> AddStudent(Student student)
        {
            return student;
        }
        
        // [HttpPut("{id}")]
        // public ActionResult<Student> Update(int id, Student student)
        // {
        //     return student;
        // }
        
    }
}
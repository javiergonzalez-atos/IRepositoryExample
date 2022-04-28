using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using ExternalSchoolAPI.Models;

namespace ExternalSchoolAPI.Models
{
    public class Student
    {
        //TODO: REMOVE
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public float Height { get; set; }
        
        //TODO: REMOVE LATER
        public float Weight { get; set; }

        public ICollection<Course> Courses { get; set; }
        
        
    }
}
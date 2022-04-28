using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EFAndLinqPractice_SchoolAPI.Models
{
    public class Course
    {
        //TODO: REMOVE
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        
        public ICollection<Student> Students { get; set; }
    }
}
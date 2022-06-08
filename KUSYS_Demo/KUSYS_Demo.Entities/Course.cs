using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS.Models
{
    public class Course
    {
        [Key]
        public long Id { get; set; }
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        //public long StudentId { get; set; }
        //public List<StudentCourse> Students { get; set; }
    }
}

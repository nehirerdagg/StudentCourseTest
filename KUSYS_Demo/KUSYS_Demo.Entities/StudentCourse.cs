using System.ComponentModel.DataAnnotations;

namespace KUSYS.Models
{
    public class StudentCourse
    {   [Key]
        public long Id { get; set; }
        public long CourseId { get; set; }
        public Course Course { get; set; }
        public long StudentId { get; set; }
        public Student Student { get; set; }
        //public List<long> CourseIdList { get; set; }


    }
}

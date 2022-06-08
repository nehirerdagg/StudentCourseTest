using System.ComponentModel.DataAnnotations;


namespace KUSYS.Models
{
    public class Student
    {
        [Key]
        public long Id { get; set; }
        public long StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        //public int CourseId { get; set; }
        //public Course Course { get; set; }
        public List<StudentCourse> Students { get; set; }


    }
}
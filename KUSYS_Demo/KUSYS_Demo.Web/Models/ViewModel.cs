using KUSYS.Models;

namespace KUSYS_DEMO.Web.Models
{
    public class ViewModel
    {

        public List<Course> course { get; set; }
        public IEnumerable<Student> student { get; set; }
        public StudentCourse studentCourses { get; set; }
        public IEnumerable<Course> Coursess { get; set; }
        public long Id { get; set;}
        public string StudentFirstName { get; set;}
        public string StudentLastName { get; set;}
        public DateTime StudentBirthDate { get; set;}
        public Student students { get; set; }


    }
}

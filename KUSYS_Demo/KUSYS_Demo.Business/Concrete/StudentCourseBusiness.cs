using KUSYS.Models;
using KUSYS_Demo.Business.Abstract;
using KUSYS_Demo.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.Business.Concrete
{
    public class StudentCourseBusiness : IStudentCourseBusiness
    {
        private readonly IStudentCourseRepository _studentCourseRepository;
        public StudentCourseBusiness(IStudentCourseRepository studentcourseRepositroy)
        {
            _studentCourseRepository = studentcourseRepositroy;
        }

        public StudentCourse CreateStudentCourse(Course course, Student student)
        {
            return _studentCourseRepository.CreateStudentCourse(course, student);
        }

        public List<StudentCourse> studentCourses(long id)
        {
            return _studentCourseRepository.StudentCourse(id);
        }
    }
}

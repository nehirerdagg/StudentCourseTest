using KUSYS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.DataAccess.Abstract
{
    public interface IStudentCourseRepository
    {
        List<StudentCourse> GetAllStudentCourse();
        StudentCourse GetStudentCourseById(long id);
        StudentCourse CreateStudentCourse(Course course, Student student);
        StudentCourse UpdateStudentCourse(StudentCourse studentCourse);
        void DeleteStudentCourse(long id);

        List<StudentCourse> StudentCourse(long id);
    
    }
}

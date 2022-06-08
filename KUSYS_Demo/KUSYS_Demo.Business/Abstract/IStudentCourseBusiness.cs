using KUSYS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.Business.Abstract
{
    public interface IStudentCourseBusiness
    {
        List<StudentCourse> studentCourses(long id);
        StudentCourse CreateStudentCourse(Course course, Student student);
   

    }
}

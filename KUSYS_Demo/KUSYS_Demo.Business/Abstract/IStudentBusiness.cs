using KUSYS.Models;
using KUSYS_Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.Business.Abstract
{
    public interface IStudentBusiness
    {
        List<Student> GetAllStudents();
        Student GetStudentById(long id);
        Student CreateStudent(Student student);
        Student UpdateStudent(Student student);
        void DeleteStudent(long id);
        Student StudentCourse(long id);
    }
}

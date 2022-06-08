using KUSYS.Models;
using KUSYS_Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.DataAccess.Abstract
{
    public interface IStudentRepositroy
    {
        List<Student> GetAllStudents();
        Student GetStudentById(long id);
        Student CreateStudent(Student student);
        Student UpdateStudent(Student student);
        void DeleteStudent(long id);

    }
}

using KUSYS.Models;
using KUSYS_Demo.Business.Abstract;
using KUSYS_Demo.DataAccess.Abstract;
using KUSYS_Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.Business.Concrete
{
    public class StudentsBusiness : IStudentBusiness
    {
        private readonly IStudentRepositroy _studentRepository;
        public StudentsBusiness(IStudentRepositroy studentRepositroy)
        {
            _studentRepository = studentRepositroy;
        }
        public Student CreateStudent(Student student)
        {
            return _studentRepository.CreateStudent(student);
        }

        public void DeleteStudent(long id)
        {
            _studentRepository.DeleteStudent(id);
        }

        public List<Student> GetAllStudents()
        {
           return _studentRepository.GetAllStudents();
        }

        public Student GetStudentById(long id)
        {
            return _studentRepository.GetStudentById(id);
        }

        public Student StudentCourse(long id)
        {
            throw new NotImplementedException();
        }

        public Student UpdateStudent(Student student)
        {
            return _studentRepository.UpdateStudent(student);
        }
    }
}

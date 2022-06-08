using KUSYS.Models;
using KUSYS_Demo.DataAccess.Abstract;
using KUSYS_Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.DataAccess.Concrete
{
    public class StudentRepository : IStudentRepositroy
    {
        private readonly Context _context;
        public StudentRepository(Context context)
        {
            _context = context;
        }
        public Student CreateStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public void DeleteStudent(long id)
        {
            var deleteStudent= _context.Students.Find(id);
            _context.Students.Remove(deleteStudent);
            _context.SaveChanges();
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(long id)
        {
            return _context.Students.Find(id);
        }

        public Student UpdateStudent(Student student)
        {
            var result = _context.Students.Find(student.Id);
            result.FirstName = student.FirstName;
            result.LastName = student.LastName;
            result.BirthDate = student.BirthDate;
            _context.Update(result);
            _context.SaveChanges();
            return student;
        }
    }
}

using KUSYS.Models;
using KUSYS_Demo.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.DataAccess.Concrete
{
    public class StudentCourseRepository : IStudentCourseRepository
    {
        private readonly Context _context;
        public StudentCourseRepository(Context context)
        {
            _context = context;
        }
        public Student CreateStudentCourse(Course course,Student student)
        {
            var resultInsert = new StudentCourse
            {
                StudentId = student.StudentId,
                CourseId = course.Id,
                Course = course,
                Student = student
            };
            _context.StudentCourses.Add(resultInsert);


            _context.SaveChanges();
            return null ;
        }
        public List<StudentCourse> CreateStudentCourse(long id)
        {
            var dersstudent = _context.StudentCourses.Where(i => i.StudentId == id).ToList();
            var allCourse = _context.Courses.ToList();

            var result = allCourse.Where(i => !dersstudent.Any(a => a.CourseId == i.Id)).ToList();
            return dersstudent;
        }
        public void DeleteStudentCourse(long id)
        {
            var deleteStudentCourse = _context.StudentCourses.Find(id);
            _context.StudentCourses.Remove(deleteStudentCourse);
            _context.SaveChanges();
        }
        public List<StudentCourse> GetAllStudentCourse()
        {
            throw new NotImplementedException();
        }
        public List<StudentCourse> GetAllStudents()
        {
            return _context.StudentCourses.ToList();
        }
        public StudentCourse GetdeleteStudentCourseById(long id)
        {
            return _context.StudentCourses.Find(id);
        }
        public StudentCourse GetStudentCourseById(long id)
        {
            throw new NotImplementedException();

        }
        public List<StudentCourse> StudentCourse(long id)
        {
            List<StudentCourse> response = _context.StudentCourses.Include(i => i.Student).Include(i => i.Course).Where(i => i.StudentId == id).ToList();
            return response;
        }
        public StudentCourse UpdateStudent(StudentCourse studentCourse)
        {
            throw new NotImplementedException();
        }

        public StudentCourse UpdateStudentCourse(StudentCourse studentCourse)
        {
            throw new NotImplementedException();
        }

        StudentCourse IStudentCourseRepository.CreateStudentCourse(Course course, Student student)
        {
            var resultInsert = new StudentCourse
            {
                StudentId = student.StudentId,
                CourseId = course.Id,
                Course = course,
                Student = student
            };
            _context.StudentCourses.Add(resultInsert);
            _context.SaveChanges();
            return null;
        }
    }
}

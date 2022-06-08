using KUSYS.Models;
using KUSYS_Demo.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.DataAccess.Concrete
{
    public class CourseRepository : ICourseRepository
    {
        private readonly Context _context;
        public CourseRepository(Context context)
        {
            _context = context;
        }

        public Course GetCourseById(long id)
        {
            return _context.Courses.Find(id);
        }

        public List<Course> StudentCourseList(long id)
        {
            var dersstudent = _context.StudentCourses.Where(i => i.StudentId == id).ToList();
            var allCourse = _context.Courses.ToList();

            var result = allCourse.Where(i => !dersstudent.Any(a => a.CourseId == i.Id)).ToList();
            return result;

        }
    }
}

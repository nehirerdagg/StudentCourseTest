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
    public class CourseBusiness : ICourseBusiness
    {
        private ICourseRepository _courseRepository;
        public CourseBusiness(ICourseRepository courseRepository)
        {
            _courseRepository= courseRepository;
        }

        public Course GetCourseById(long id)
        {
            return _courseRepository.GetCourseById(id);
        }

        public List<Course> StudentCourseList(long id)
        {
           return _courseRepository.StudentCourseList(id);
        }
    }
}

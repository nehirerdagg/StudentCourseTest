using KUSYS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.DataAccess.Abstract
{
    public interface ICourseRepository
    {
        List<Course> StudentCourseList(long id);
        Course GetCourseById(long id);
    }
}

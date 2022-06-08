using KUSYS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KUSYS_Demo.Business.Abstract
{
    public  interface ICourseBusiness
    {
        List<Course> StudentCourseList(long id);
        Course GetCourseById(long id);
    }
}

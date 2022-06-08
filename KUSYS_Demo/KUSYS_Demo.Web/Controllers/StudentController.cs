using KUSYS_Demo.Business.Abstract;
using KUSYS_Demo;
using Microsoft.AspNetCore.Mvc;
using KUSYS.Models;
using KUSYS_DEMO.Web.Models;

namespace KUSYS_Demo.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentBusiness _studentBusiness;
        private readonly IStudentCourseBusiness _studentCourseBusiness;
        private readonly ICourseBusiness _courseBusiness;
        public StudentController(IStudentBusiness studentBusiness,ICourseBusiness courseBusiness,IStudentCourseBusiness studentCourseBusiness)
        {
            _studentBusiness = studentBusiness;
            _studentCourseBusiness = studentCourseBusiness;
            _courseBusiness = courseBusiness;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Editing_CreateStudent(string FirstName, string LastName, DateTime BirthDate)
        {
            var studentcreate = new Student();
            studentcreate.FirstName = FirstName;
            studentcreate.LastName = LastName;
            studentcreate.BirthDate = BirthDate;
            var student = _studentBusiness.CreateStudent(studentcreate);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult UpdateStudent(long id)
        {
            var result = _studentBusiness.GetStudentById(id);
            return View(result);
        }
        [HttpGet]
        public async Task<IActionResult> Editing_ShowStudent(long id)
        {
            var result = _studentBusiness.GetStudentById(id);
            return View("StudentShow", result);
        }
        public IActionResult Editing_UpdateStudent(Student student)
        {
            var result = _studentBusiness.UpdateStudent(student);

            return RedirectToAction("Index", "Home");
        }
        public IActionResult DeleteStudent(long id)
        {
          _studentBusiness.DeleteStudent(id);

            return RedirectToAction("Index", "Home");
        }
        public IActionResult ShowStudent(long id)
        {
            var result = _studentBusiness.GetStudentById(id);
            return View(result);
        }
        [HttpGet]
        public IActionResult StudentCourse(long Id)
        {
            ViewBag.StudentID = Id;
            var result = _studentCourseBusiness.studentCourses(Id);
            List<StudentCourse> response = result.ToList();
            return View(response);
        }
        ///////
        ///


        [HttpPost]
        public IActionResult CreateStudentCourse(long Id)
        {
            ViewBag.StudentID = Id;

            var result = _courseBusiness.StudentCourseList(Id);

            var model = new ViewModel()
            {
                Coursess = result.ToList(),
                Id = Id,
            };

            return View(model);
        }
        [HttpPost]
        public IActionResult Editing_CreateStudentCourse(ViewModel model)
        {
            var repo = _courseBusiness.GetCourseById(model.studentCourses.Course.Id);
            var repostudent = _studentBusiness.GetStudentById(model.studentCourses.StudentId);

            _studentCourseBusiness.CreateStudentCourse(repo,repostudent);
            //List<StudentCourse> response = resultInsert.ToList();

            return RedirectToAction("Index", "Home");
        }
    }
}

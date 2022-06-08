using KUSYS.Models;
using KUSYS_Demo.Business.Abstract;
using KUSYS_Demo;
using KUSYS_Demo.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Web.Mvc.Html;


using Newtonsoft.Json;
using ActionResult = System.Web.Mvc.ActionResult;

namespace KUSYS_Demo.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentBusiness _studentBusiness;

        public HomeController(ILogger<HomeController> logger,IStudentBusiness studentBusiness)
        {
            _logger = logger;
            _studentBusiness = studentBusiness;
        }

        public IActionResult Index()
        {
           List<Student> data= _studentBusiness.GetAllStudents();
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
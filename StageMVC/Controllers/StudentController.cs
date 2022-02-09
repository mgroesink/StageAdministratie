using Microsoft.AspNetCore.Mvc;
using StageLib;

namespace StageMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var s1 = new Student("rsk01", "Marcel", "Roesink");
            var s2 = new Student();
            var s = s1.Voornaam;
            return View();
        }
    }
}

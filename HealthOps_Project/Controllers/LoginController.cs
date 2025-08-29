using Microsoft.AspNetCore.Mvc;

namespace HealthOps_Project.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

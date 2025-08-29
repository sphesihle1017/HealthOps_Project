using Microsoft.AspNetCore.Mvc;

namespace HealthOps_Project.Controllers
{
    public class SignInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace PetsSocial.Controllers
{
    public class PetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

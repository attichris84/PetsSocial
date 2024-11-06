using Microsoft.AspNetCore.Mvc;

namespace PetsSocial.Controllers
{
    public class MeetupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

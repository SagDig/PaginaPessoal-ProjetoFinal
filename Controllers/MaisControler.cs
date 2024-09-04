using Microsoft.AspNetCore.Mvc;

namespace YourProjectNamespace.Controllers
{
    public class MaisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

         public IActionResult Contatos()
        {
            return View();
        }
    }
}
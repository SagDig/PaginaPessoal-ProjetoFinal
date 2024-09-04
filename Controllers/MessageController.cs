using Microsoft.AspNetCore.Mvc;
using YourProjectNamespace.Models;
namespace YourProjectNamespace.Controllers
{
    public class MessageController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Message message)
        {
            ViewBag.Name = message.Nome;
            ViewBag.Email = message.Email;
            ViewBag.Message = message.Content;
            ViewBag.Message = message.Endereco;
            ViewBag.Message = message.Cpf;
            return View();
        }

        public IActionResult Mais()
        {
            return View();
        }


    }
}
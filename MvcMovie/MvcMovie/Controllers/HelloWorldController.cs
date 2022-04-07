using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // Cada método 'public' em um controlador pode ser chamado como um ponto de extremidade HTTP.
        // O primeiro comentário indica que este é um método HTTP GET invocado por meio do acréscimo de /HelloWorld/ à URL base.

        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = $"Hello, {name}";
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}

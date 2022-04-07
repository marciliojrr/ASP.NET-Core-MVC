using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // Cada método 'public' em um controlador pode ser chamado como um ponto de extremidade HTTP.
        // O primeiro comentário indica que este é um método HTTP GET invocado por meio do acréscimo de /HelloWorld/ à URL base.

        // GET: /HelloWorld/
        public string Index()
        {
            return "This is my default action...";
        }

        // GET: /HelloWorld/Welcome/
        public string Welcome(string name, int ID = 1)
        {
            // HtmlEncoder.Default.Encode protege o aplicativo contra entradas mal-intencionadas, como por meio de JavaScript.
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}.");
        }
    }
}

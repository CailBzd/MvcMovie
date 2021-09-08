using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;


namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            //return "This is the Welcome action methos...";
            //return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");

            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
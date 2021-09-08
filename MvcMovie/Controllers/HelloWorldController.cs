using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWordlController : Controller
    {

        public string Index()
        {
            return "This is my default action...";
        }

        public string Welcome()
        {
            return "This is the Welcome action methos...";
        }
    }
}
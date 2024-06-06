using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace HelloWorld.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        //GET: /HelloWorld

        public IActionResult Index()
        {
            //return "This is default controller for MVC Movie controller....";
            //ViewData["name"] = "Index Page View";
            return View();
        }

        //
        //GET: /HelloWorld/Welcome

        public IActionResult Welcome(string name, int idno = 1)
        {
            //return "This is Bhargav's Welcome Message for MVC Movie controller...";
            //return ($" Hello {name}, ID is: {idno}") ;
            ViewData["name"] = "Hello " + name;
            ViewData["idno"] = idno;
            return View();
        
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace MVC_in_Dotnet.Controllers
{
    public class HomeController : Controller
    {
       //public string Index()
       // {
       //     return "AOA Pakistan...!";
       // }

        public IActionResult Index()
        {
            // Sending data to the view from controller.

            string myData = "This is some dummy data from Home Controller!";
            return View("Index", myData);
        }

       
    }
}

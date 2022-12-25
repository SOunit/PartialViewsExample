using Microsoft.AspNetCore.Mvc;

namespace PartialViewsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            //ViewData approach
            //ViewData["ListTitle"] = "Cities";
            //ViewData["ListItems"] = new List<string>
            //{
            //    "Item1",
            //    "Item2",
            //    "Item3",
            //    "Item4",
            //};

            return View();
        }
        
        [Route("about")]
        public IActionResult About()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Lap2.Views
{
    public class TodoController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

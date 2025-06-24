using Microsoft.AspNetCore.Mvc;

namespace Book.Web.Controllers
{
    public class CategoryControler : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

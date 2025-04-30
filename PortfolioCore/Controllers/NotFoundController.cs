using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Controllers
{
    public class NotFoundController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

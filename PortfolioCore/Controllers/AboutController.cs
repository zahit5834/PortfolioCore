using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class AboutController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        [HttpGet]
        public IActionResult Index()
        {
            var value = context.Abouts.FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult Index(About p)
        {
            context.Abouts.Update(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

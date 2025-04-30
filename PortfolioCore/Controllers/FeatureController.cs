using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class FeatureController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        [HttpGet]
        public IActionResult Index()
        {
            var values = context.Features.FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature p)
        {
            context.Features.Update(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

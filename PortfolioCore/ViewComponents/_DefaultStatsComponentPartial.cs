using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultStatsComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        Random rnd = new Random();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1=context.Testimonials.Count();
            ViewBag.v2=context.Portfolios.Count();
            ViewBag.v3=context.Skills.Count();
            ViewBag.v4 = rnd.Next(10, 20);
            return View();
        }
    }
}

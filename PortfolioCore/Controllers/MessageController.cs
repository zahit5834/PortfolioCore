using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class MessageController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {
            var values = context.Messages.ToList();
            return View(values);
        }

        public IActionResult MessageDetail(int id)
        {
            var values = context.Messages.Where(x => x.MessageId == id).ToList();
            return View(values);
        }

        [HttpPost]
        public IActionResult SentMessage(Message p)
        {
            p.SendDate = DateTime.Now;
            p.IsRead = false;
            context.Messages.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
        public IActionResult DeleteMessage(int id)
        {
            var values = context.Messages.Find(id);
            context.Messages.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ChangeReadStatus(int id)
        {
            var values = context.Messages.Find(id);
            if (values.IsRead == false)
            {
                values.IsRead = true;
            }
            else
            {
                values.IsRead = false;
            }
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

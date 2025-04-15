using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class SkillController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult SkillList()
        {
            var values = context.Skills.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSkill(Skill p)
        {
            context.Skills.Add(p);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
        public IActionResult DeleteSkill(int id)
        {
            var value = context.Skills.Find(id);
            context.Skills.Remove(value);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var value = context.Skills.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateSkill(Skill p)
        {
            context.Skills.Update(p);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }
}

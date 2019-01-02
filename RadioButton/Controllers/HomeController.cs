using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RadioButton.Data;
using RadioButton.Models;

namespace RadioButton.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult ContactForm()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost, ActionName("ContactForm")]
        public ActionResult ContactFormPost(ContactModel model)
        {
            ViewBag.Message = "Your contact page.";
            _context.ContactModels.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

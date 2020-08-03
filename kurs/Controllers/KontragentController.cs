using kurs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kurs.Controllers
{
    public class KontragentController : Controller
    {
        private ApplicationContext db;
        public KontragentController(ApplicationContext context)
        {
            db = context;
        }


        public async Task<IActionResult> Index()
        {
            return View(await db.Kontragents.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Kontragent kontragent)
        {
            db.Kontragents.Add(kontragent);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}


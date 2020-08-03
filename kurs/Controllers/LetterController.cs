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
    public class LetterController : Controller
    {

        private ApplicationContext db;
        public LetterController(ApplicationContext context)
        {
            db = context;
        }
        //public ActionResult Index()
        //{
        //    var letter = db.Letters.Include(c => c.Kontragent);          
        //    return View(letter.ToList());
        //}
        public async Task<IActionResult> Index()
        {
            var letter = db.Letters
                .Include(c => c.Kontragent)
                .AsNoTracking();
            return View(await letter.ToListAsync());
        }
        [HttpGet]
        public ActionResult Create()
        {
            PopulateDepartmentsDropDownList();
            return View();
            // Формируем список  для передачи в представление
            //SelectList kontr = new SelectList(db.Kontragents, "Kontragent", "NameContragent");
            //ViewBag.Kontragents = kontr;
            //return View();
        }

        private void PopulateDepartmentsDropDownList(object selectedKontragent = null)
        {
            var departmentsQuery = from d in db.Kontragents
                                   orderby d.NameContragent
                                   select d;
            ViewBag.KontragentId = new SelectList(departmentsQuery.AsNoTracking(), "KontragentId", "NameContragent", selectedKontragent);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LetterId,Number,Date,Type,FormSec,KontragentId ")] Letter letter)
        {
            if (ModelState.IsValid)
            {
                db.Add(letter);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            PopulateDepartmentsDropDownList(letter.KontragentId);
            return View(letter);
        }

        //[HttpPost]
        //public ActionResult Create(Letter letter)
        //{
        //    //Добавляем игрока в таблицу
        //    db.Letters.Add(letter);
        //    db.SaveChanges();
        //    // перенаправляем на главную страницу
        //    return RedirectToAction("Index");
        //}
    }
}

using Microsoft.AspNetCore.Mvc;
using PersonelAreasUygulama.Models;
using PersonelAreasUygulama.Models.ViewModels;

namespace PersonelAreasUygulama.Areas.Yonetim.Controllers
{
    [Area("Yonetim")]
    public class HomeController : Controller
    {
        private readonly Context db;
        public HomeController(Context _db)
        {
            db = _db;
        }

        PersonelVM model = new PersonelVM();
        public IActionResult Index()
        {
            model.pList = db.Personels.Select(x => new PersonelDTO() { Ad = x.Ad, Soyad = x.Soyad, Maas = x.Maas }).ToList();
            return View(model);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Personel model)
        {
            db.Personels.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(string id)
        {
            db.Personels.Remove(db.Personels.FirstOrDefault(x => x.Ad == id));
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

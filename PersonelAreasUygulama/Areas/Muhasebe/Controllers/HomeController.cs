using Microsoft.AspNetCore.Mvc;
using PersonelAreasUygulama.Models;
using PersonelAreasUygulama.Models.ViewModels;

namespace PersonelAreasUygulama.Areas.Muhasebe.Controllers
{
    [Area("Muhasebe")]
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
            model.pList = db.Personels.Select(x => new PersonelDTO(){ Ad = x.Ad, Soyad=x.Soyad,Maas = x.Maas}).ToList();

            return View(model);
        }
    }
}



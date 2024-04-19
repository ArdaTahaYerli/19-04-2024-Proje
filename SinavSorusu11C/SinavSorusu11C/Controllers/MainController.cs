using Microsoft.AspNetCore.Mvc;
using SinavSorusu11C.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinavSorusu11C.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index(int? id)
        {
            AnasayfaViewModel model;
            var kategoriler = Fabrika.Kategoriler;
            if (id!=null) // adres satırıda id varsa
            {
                model = new AnasayfaViewModel
                {
                    Kategoriler = kategoriler,
                    Haberler = Fabrika.Haberler.Where(h=>h.KategoriId==id).ToList()
                };
                ViewBag.kategoriId = id;
                ViewBag.kategoriAd = Fabrika.Kategoriler.FirstOrDefault(k => k.Id == id).Ad;
            }
            else // id yoksa
            {
                model = new AnasayfaViewModel
                {
                    Kategoriler = kategoriler,
                    Haberler = Fabrika.Haberler
                };
            }
            
            return View(model);
        }
    }
}

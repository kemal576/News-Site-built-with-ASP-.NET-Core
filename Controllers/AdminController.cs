using System;
using iwp.Data;
using iwp.Models;
using Microsoft.AspNetCore.Mvc;

namespace iwp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult NewsList()
        {
            return View(NewsRepository.GetAllNews());
        }

        [HttpGet]
        public IActionResult CreateNews()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateNews(NewsUpdateModel newsUpdateModel)
        {
            var haber = new News()
            {
                haberBasligi = newsUpdateModel.haberBasligi,
                haberIcerigi = newsUpdateModel.haberIcerigi,
                haberKaynagi = newsUpdateModel.haberKaynagi,
                haberResmi = newsUpdateModel.haberResmi,
                haberYazari = newsUpdateModel.haberYazari,
                categoryId = newsUpdateModel.categoryId,
                isHome = newsUpdateModel.isHome
            };

            NewsRepository.AddNews(haber);
            return RedirectToAction("NewsList");
        }

        [HttpGet]
        public IActionResult EditNews(int? Id)
        {
            if (Id != null)
            {
                var entity = NewsRepository.GetNewsbyId((int)Id);
                if (entity != null)
                {
                    var haber = new NewsUpdateModel()
                    {
                        Id = entity.haberId,
                        haberBasligi = entity.haberBasligi,
                        haberIcerigi = entity.haberIcerigi,
                        haberKaynagi = entity.haberKaynagi,
                        haberResmi = entity.haberResmi,
                        haberYazari = entity.haberYazari,
                        categoryId = entity.categoryId,
                        isHome = entity.isHome
                    };
                    return View(haber);
                }
                else
                    return NotFound();
            }
            else
                return NotFound();
        }

        [HttpPost]
        public IActionResult EditNews(NewsUpdateModel newsUpdateModel)
        {
            var entity = NewsRepository.GetNewsbyId(newsUpdateModel.Id);
            if (entity == null)
            {
                return NotFound();
            }
            Console.WriteLine(newsUpdateModel.haberBasligi);
            entity.haberBasligi = newsUpdateModel.haberBasligi;
            entity.haberIcerigi = newsUpdateModel.haberIcerigi;
            entity.haberKaynagi = newsUpdateModel.haberKaynagi;
            entity.haberResmi = newsUpdateModel.haberResmi;
            entity.haberYazari = newsUpdateModel.haberYazari;
            entity.categoryId = newsUpdateModel.categoryId;
            entity.isHome = newsUpdateModel.isHome;
            NewsRepository.UpdateNews(entity);
            return RedirectToAction("NewsList");
        }

        
        public IActionResult DeleteNews(int Id)
        {
                var haber = NewsRepository.GetNewsbyId(Id);
                if (haber != null)
                {
                    NewsRepository.DeleteNews(haber);
                    return RedirectToAction("NewsList");
                }
                else return NotFound();
        }

    }
}
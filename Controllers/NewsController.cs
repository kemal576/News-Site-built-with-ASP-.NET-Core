using System.Linq;
using iwp.Data;
using Microsoft.AspNetCore.Mvc;

namespace iwp.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Read(int Id)
        {
            return View(NewsRepository.GetNewsbyId(Id));
        }

        public IActionResult Category(int Id)
        {
            var haberler = NewsRepository.Haberler;
            haberler = haberler.Where(c => c.categoryId == Id).ToList();
            return View(haberler);
        }

        public IActionResult Search(string q)
        {
            var haberler = NewsRepository.Haberler;
            if (!string.IsNullOrEmpty(q))
            {
                haberler = haberler.Where(h => h.haberBasligi
                .ToLower().Contains(q.ToLower()) || h.haberIcerigi.ToLower().Contains(q)).ToList();
            }
            return View(haberler);
        }
    }
}
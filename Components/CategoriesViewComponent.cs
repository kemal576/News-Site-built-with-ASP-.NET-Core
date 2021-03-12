using iwp.Data;
using Microsoft.AspNetCore.Mvc;

namespace iwp.ViewComponents
{
    public class CategoriesViewComponent:ViewComponent
    {   
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["id"];
            return View(CategoryRepository.Categories);
        }
    }
}
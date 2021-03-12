using System.Collections.Generic;
using System.Linq;
using iwp.Entity;
using iwp.Models;

namespace iwp.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository()
        {
            using(var db = new NewsContext())
            {
                _categories = db.Categories.ToList();
            }
        }

        public static List<Category> Categories
        {
            get{return _categories;}
        }

        public static void AddCategory(Category category)
        {
            _categories.Add(category);
        }

        public static Category GetCategorybyId(int Id)
        {
            return _categories.FirstOrDefault(c=>c.categoryId==Id);
        }
        
    }
}
using System.Collections.Generic;
using System.Linq;
using iwp.Entity;
using iwp.Models;
using Microsoft.EntityFrameworkCore;

namespace iwp.Data
{
    public static class NewsRepository
    {
        private static List<News> _haberler = null;
        static NewsRepository()
        {
            using (var db = new NewsContext())
            {
                _haberler = db.News.ToList();
            }

        }

        public static List<News> Haberler
        {
            get
            {
                return _haberler;
            }
        }

        public static void AddNews(News news)
        {
            using (var db = new NewsContext())
            {
               db.News.Add(news);
               db.SaveChanges();
            }
            
        }
        public static List<News> GetAllNews()
        {
            using (var db = new NewsContext())
            {
                _haberler = db.News.ToList();
            }
            return _haberler;
        }
        public static News GetNewsbyId(int id)
        {
            return _haberler.FirstOrDefault(h => h.haberId == id);
        }

        public static void UpdateNews(News news)
        {
            using (var context = new NewsContext())
            {
                context.Entry(news).State = EntityState.Modified;
                context.SaveChanges();
            }

        }

        public static void DeleteNews(News news)
        {
            using (var context = new NewsContext())
            {
                context.News.Remove(news);
                context.SaveChanges();
            }
        }


    }
}
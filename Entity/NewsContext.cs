using iwp.Models;
using Microsoft.EntityFrameworkCore;

namespace iwp.Entity
{
    public class NewsContext:DbContext
    {
        public DbSet<News> News { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=news.db");
        }
    }
}
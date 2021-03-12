using System;
using System.ComponentModel.DataAnnotations;

namespace iwp.Models
{
    public class News
    {
        [Key]
        public int haberId { get; set; }
        public string haberBasligi { get; set; }
        public string haberIcerigi { get; set; }
        public string haberResmi { get; set; }
        public string haberYazari { get; set; }
        public DateTime haberTarihi { get; set; } //
        public int haberTiklanmasi { get; set; }  //
        public string haberKaynagi { get; set; }
        public int categoryId { get; set; }
        public bool isHome {get; set;}

        public News()
        {
            haberTarihi = DateTime.Now;
            haberTiklanmasi = 0;
        }

    }
}
namespace iwp.Models
{
    public class NewsUpdateModel
    {
        public int Id { get; set; }
        public string haberBasligi { get; set; }
        public string haberIcerigi { get; set; }
        public string haberResmi { get; set; }
        public string haberYazari { get; set; }
        public string haberKaynagi { get; set; }
        public int categoryId { get; set; }
        public bool isHome { get; set; }
    }
}
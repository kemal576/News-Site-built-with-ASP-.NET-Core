using System.ComponentModel.DataAnnotations;

namespace iwp.Models
{
    public class Category
    {
        [Key][Required]
        public int categoryId { get; set; }
        [MaxLength(100)][Required]
        public string Name { get; set; }
        
        
    }
}
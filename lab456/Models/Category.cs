using System.ComponentModel.DataAnnotations;

namespace lab456.Models
{
    public class Category
    {
        public byte id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
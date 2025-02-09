using System.ComponentModel.DataAnnotations;

namespace EasyCartAPI.Model 
{   
    public enum ProductCondition
    {
        New, // 0
        Used // 1
    }
    public class Product
    {
        [Key]
        public int Product_Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public byte[]? Picture { get; set; }
        public ProductCondition Condition { get; set; } 
        public string Description { get; set; } = string.Empty;
        public int Weight { get; set; }
        public double Price { get; set; } // Will be changed to decimal later
        public int Stock { get; set; }
        public int Min_Purchase { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }
    }
}
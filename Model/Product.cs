namespace EasyCartAPI.Model 
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; } // Will be changed to decimal later
        public string Description { get; set; }
    }
}
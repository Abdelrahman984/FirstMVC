namespace FirstMVC.Models
{
    public class ProductSampleData
    {
        private readonly List<Product> products =
        [
            new Product { Id = 1, Name = "Laptop", Price = 1200.00m, Image = "laptop.jpg", Description = "High performance laptop" },
            new Product { Id = 2, Name = "Smartphone", Price = 800.00m, Image = "smartphone.jpg", Description = "Latest model smartphone" },
            new Product { Id = 3, Name = "Tablet", Price = 500.00m, Image = "tablet.jpg", Description = "Portable tablet with great features" },
            new Product { Id = 4, Name = "Smartwatch", Price = 250.00m, Image = "smartwatch.jpg", Description = "Stylish smartwatch with health tracking" },
        ];
        public List<Product> GetAll()
        {
            return products;
        }
        public Product GetById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
    }
}

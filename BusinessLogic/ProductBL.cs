using ProductCatalogMVC.Models;

namespace ProductCatalogMVC.BusinessLogic
{
    public class ProductBL
    {
        private List<Product> products;

        public ProductBL()
        {
            products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    ProductName = "iPhone 17",
                    ProductPrice = 999,
                    ImageUrl = "/images/17.jpg",
                    Description = "Latest Apple iPhone with A17 chip"
                },
                new Product
                {
                    Id = 2,
                    ProductName = "AirPods",
                    ProductPrice = 249,
                    ImageUrl = "/images/airpods.jfif",
                    Description = "Noise cancelling wireless earbuds"
                },
                new Product
                {
                    Id = 3,
                    ProductName = "Lenovo laptop",
                    ProductPrice = 699,
                    ImageUrl = "/images/Lenovo.jpg",
                    Description = "Lightweight and powerful Laptop"
                },
                new Product
                {
                    Id = 4,
                    ProductName = "beats headset",
                    ProductPrice = 499,
                    ImageUrl = "/images/beats.jpg",
                    Description = "An ultra light-weight head set"
                },
                new Product
                {
                    Id = 5,
                    ProductName = "Apple Watch",
                    ProductPrice = 399,
                    ImageUrl = "/images/watch.jpg",
                    Description = "Smartwatch with fitness tracking"
                }
            };
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using ProductCatalogMVC.BusinessLogic;

namespace ProductCatalogMVC.Controllers
{
    public class ProductController : Controller
    {
        private ProductBL productBL = new ProductBL();

        public IActionResult ShowAll()
        {
            var products = productBL.GetAllProducts();
            return View(products);
        }

        public IActionResult ShowById(int id)
        {
            var product = productBL.GetProductById(id);

            if (product == null)
            {
                return NotFound("Product not found");
            }

            return View(product);
        }
    }
}

using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductSampleData productSampleData = new ProductSampleData();
            List<Product> ProductList = productSampleData.GetAll();
            return View("DisplayAllProducts", ProductList);
        }
        public IActionResult Details(int id)
        {
            ProductSampleData productSampleData = new ProductSampleData();
            Product product = productSampleData.GetById(id);
            return View("DisplayProductDetails", product);
        }
    }
}
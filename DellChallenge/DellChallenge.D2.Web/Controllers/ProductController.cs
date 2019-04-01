using DellChallenge.D2.Web.Models;
using DellChallenge.D2.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace DellChallenge.D2.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _productService.GetAll();
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(NewProductModel newProduct)
        {
            _productService.Add(newProduct);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(string id)
        {
            if (string.IsNullOrEmpty(id))
                return RedirectToAction("Index");

            ProductModel p = _productService.Get(id);
            return View("Update", p);
        }

        [HttpPost]
        public IActionResult Update(ProductModel product)
        {
            if(ModelState.IsValid)
            {
                _productService.Update(product);
                return RedirectToAction("Index");
            }
            return View("Update", product.Id);
        }

        [HttpPost]
        public IActionResult Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
                return RedirectToAction("Error");
            ProductModel p = _productService.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
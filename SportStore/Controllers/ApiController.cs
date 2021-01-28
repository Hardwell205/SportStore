using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using System.Collections.Generic;

namespace SportStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private IProductRepository repository;
        public ApiController(IProductRepository repository)
        {
            this.repository = repository;
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int ProductID)
        {
            repository.DeleteProduct(ProductID);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IEnumerable<Product> Get() => repository.Products;
        [HttpGet("{ProductID}")]
        public Product Get(int ProductID) => repository[ProductID];
        [HttpPost]
        public IActionResult SaveProduct(Product product)
        {
            repository.SaveProduct(product);
            return RedirectToAction("Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using System.Collections.Generic;

namespace SportStore.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IProductRepository repository;
        public HomeController(IProductRepository repository)
        {
            this.repository = repository;
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int ProductID)
        {
            repository.DeleteProduct(ProductID);
            return RedirectToAction("Index");


        }
        

        
    }
}

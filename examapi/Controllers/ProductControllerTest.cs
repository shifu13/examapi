using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using examapi.Model;
using examapi.Data;

namespace examapi.Controllers
{
    [Route("api/producttest")]
    [ApiController]
    public class ProductControllerTest : ControllerBase
    {
        private readonly MockProductRepo _repository = new MockProductRepo();
        //Get api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAllProducts()
        {
            var productItems = _repository.GetAppProduct();
            return Ok(productItems);
        }

        //Get api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id) //The id comes from the request from the UI.
        {
            var productItem = _repository.GetProductById(id);
            return Ok(productItem);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace examapi.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class ProductControllerTest : ControllerBase
    {
        [HttpGet]
        public ActionResult <IEnumerable<Product>> GetAllProducts()
        {

        }
    }
}

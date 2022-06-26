using System.Collections.Generic;
using BLL.Bll.Product;
using Contract.Models.Product;
using Microsoft.AspNetCore.Mvc;

namespace MCSAtividade1.Controllers
{
    [Route("[controller]/v1")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductBll _productBll;
        public ProductsController(IProductBll productBll)
        {
            _productBll = productBll;
        }

        /// <summary>
        /// Returns all products by store name
        /// </summary>
        [HttpGet()]
        [ProducesResponseType(200, Type = typeof(List<Product>))]
        public IActionResult GetProductsByStoreName([FromQuery]string storeName)
        {
            var productsByStore = _productBll.GetAll(storeName);

            if (productsByStore.Count <= 0)
                return NoContent();

            return Ok(productsByStore);
        }
    }
}
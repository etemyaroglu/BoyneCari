using BoyneCari.Models.Requests.Product;
using BoyneCari.Services.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using System;
using System.Threading.Tasks;

namespace BoyneCari.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        #region .ctor
        private readonly IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        #endregion

        #region Methods

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById([FromRoute] string id)
        {
            return Ok(await productService.GetProductByIdAsync(id));
        }

        [HttpGet("list")]
        public IActionResult GetProducts()
        {
            return Ok(productService.GetProducts());

        }
        [HttpGet("filter")]
        public IActionResult GetProductsFilter([FromQuery] RequestProductFilter model)
        {
            return Ok(productService.GetProductsFilter(model));
        }

        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [HttpPost]
        public IActionResult CreateProduct([FromBody] RequestProductInsert request)
        {
            return Ok(productService.InsertProduct(request));
        }

        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [HttpPut("{id}")]
        public IActionResult UpdateProduct([FromRoute] string id, [FromBody] RequestProductUpdate request)
        {
            return Ok(productService.UpdateProduct(id, request));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct([FromRoute] string id)
        {
            productService.DeleteProductById(id);
            return Ok();
        }
#endregion

    }
}

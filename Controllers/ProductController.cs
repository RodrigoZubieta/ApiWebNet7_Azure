using Microsoft.AspNetCore.Mvc;
using WepApiNet7.Dto;
using WepApiNet7.Interface;
using WepApiNet7.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WepApiNet7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet]
        public ActionResult GetAllProducts()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var product = _productService.GetProductById(id);
            return Ok(product);
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProductDTO productDTO)
        {
            _productService.CreateProduct(productDTO);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ProductDTO productDTO)
        {
            _productService.UpdateProduct(id, productDTO);
            return Ok();
        }

        
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _productService.DeleteProduct(id);
            return Ok();
        }
    }
}

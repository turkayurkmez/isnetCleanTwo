using Microsoft.AspNetCore.Mvc;
using shop.Application;
using shop.Application.DTOs.Responses;

namespace shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            //request'i denetle (validasyon)
            //business'a ilet
            //sonucu istemciye ilet.

            List<ProductDisplayResponse> products = _productService.GetProducts();
            return Ok(products);
        }

    }
}

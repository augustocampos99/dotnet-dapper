using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleDapper.Repositories.Interfaces;

namespace SimpleDapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productRepository.GetAll();

            return Ok(result);
        }

    }
}

using ApplicationCore.Interface;
using ApplicationCore.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MMT_Web_Api.Controllers
{

    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/Product
        [Route("api/[controller]")]
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productService.GetAllProduct();
        }


        // GET: api/category/5/Product
        [Route("api/category/{CategoryId}/Product")]
        [HttpGet("{Id}", Name = "GetByCategory")]

        public IEnumerable<Product> Get(int CategoryId)
        {
            return _productService.GetByCategoryId(CategoryId);
        }
    }
}

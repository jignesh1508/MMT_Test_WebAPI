using ApplicationCore.Interface;
using ApplicationCore.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MMT_Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: api/Category
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _categoryService.GetAllCategory();
        }

        // GET: api/Category/5
        [HttpGet("{id}", Name = "Get")]
        public Category Get(int id)
        {
            return _categoryService.GetById(id);
        }
    }
}
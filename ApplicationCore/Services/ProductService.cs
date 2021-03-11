using ApplicationCore.Interface;
using ApplicationCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationCore.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repository;
        private readonly ICategoryService _categoryService;

        public ProductService(IRepository<Product> repository,ICategoryService categoryService)
        {
            _repository = repository;
            _categoryService = categoryService;
        }

        public IEnumerable<Product> GetAllProduct()
        {
            var products = _repository.ListAll("spGetAllProducts").ToList();

            if (products == null)
            {
                return null;
            }
            return products;
        }

        public IEnumerable<Product> GetByCategoryId(int CategoryId)
        {
            if (CategoryId == 0)
            {
                return null;
            }

            return _repository.ListAllById(CategoryId, "spGetProductsByCategory").ToList();

        }

        public Product GetById(int id)
        {
            if(id==0)
            {
                return null;
            }

            var product = _repository.GetById(id);

            return product;
        }

    }
}

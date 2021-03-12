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
            List<Product> products = new List<Product>();
            try
            {
                 products = _repository.ListAll("spGetAllProducts").ToList();

                if (products == null || products.Count==0)
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                //We can write exception in logger file.
                return null;
            }
           
            return products;
        }

        public IEnumerable<Product> GetByCategoryId(int CategoryId)
        {
            List<Product> products = new List<Product>();
            try
            {
                if (CategoryId == 0)
                {
                    return null;
                }
                products = _repository.ListAllById(CategoryId, "spGetProductsByCategory").ToList();
            }
            catch(Exception ex)
            {
                //We can write exception in logger file.
                return null;
            }

            return products;
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

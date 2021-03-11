using ApplicationCore.Model;
using System;
using System.Collections.Generic;

namespace ApplicationCore.Interface
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProduct();
        Product GetById(int id);
        IEnumerable<Product> GetByCategoryId(int CategoryId);
    }
}

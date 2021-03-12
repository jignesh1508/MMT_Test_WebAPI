using ApplicationCore.Interface;
using ApplicationCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationCore.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _repository;

        public CategoryService(IRepository<Category> repository)
        {
            _repository = repository;
        }
        public IEnumerable<Category> GetAllCategory()
        {
            List<Category> categories = new List<Category>();

            try
            {
                categories = _repository.ListAll("spGetAllCategory").ToList();

                if (categories == null)
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                //We can write exception in logger file.
                return null;
            }

            return categories;

        }

        public Category GetById(int id)
        {
            if (id == 0)
            {
                return null;
            }

            return _repository.GetById(id);

        }
    }
}

using ApplicationCore.Interface;
using ApplicationCore.Model;
using System.Collections.Generic;

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
            var categories = _repository.ListAll("spGetAllCategory");

            if(categories==null)
            {
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

            return  _repository.GetById(id);

        }
    }
}

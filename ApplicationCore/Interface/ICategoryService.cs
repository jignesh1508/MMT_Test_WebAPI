using ApplicationCore.Model;
using System.Collections.Generic;

namespace ApplicationCore.Interface
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAllCategory();
        Category GetById(int id);
    }
}

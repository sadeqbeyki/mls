using MLS.Application.Interfaces.TaskCategory;
using MLS.Core.Entities;

namespace MLS.Core.ApplicationServices
{
    public class TaskCategoryService
    {
        private readonly ITaskCategoryRepository _categoryRepository;

        public TaskCategoryService(ITaskCategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void CreateCategory(string name)
        {
            if(!string.IsNullOrEmpty(name))
            {
                //var categoryInDb = _categoryRepository.Search(name);
                //if(categoryInDb == null|| categoryInDb.Id<1)
                //{
                //
                //    var category = new ProductCategory
                //    {
                //        Name = name,
                //    };
                //    _categoryRepository.Create(category);
                //}
            }
        }
    }
}
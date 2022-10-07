using MLS.Core.Contracts;
using MLS.Core.Entities;

namespace MLS.Core.ApplicationServices
{
    public class ProductCategoryService
    {
        private readonly IProductCategoryRepository _categoryRepository;

        public ProductCategoryService(IProductCategoryRepository categoryRepository)
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
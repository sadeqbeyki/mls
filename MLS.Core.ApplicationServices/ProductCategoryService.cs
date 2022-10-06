using MLS.Core.Contracts;
using MLS.Core.Entities;

namespace MLS.Core.ApplicationServices
{
    public class ProductCategoryService
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryService(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public void CreateCategory(string name)
        {
            if(!string.IsNullOrEmpty(name))
            {
                var categoryInDb = _productCategoryRepository.Search(name);
                if(categoryInDb == null|| categoryInDb.Id<1)
                {
                    var category = new ProductCategory
                    {
                        Name = name,
                    };
                    _productCategoryRepository.Create(category);
                }
            }
        }
    }
}
using MLS.Core.Contracts;
using MLS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.DAL.EF.Repositories
{
    public class EFProductCategoryRepository : IProductCategoryRepository
    {
        private static List<ProductCategory> categories = new List<ProductCategory>();
        public void Create(ProductCategory productCategory)
        {
            categories.Add(productCategory);
        }

        public ProductCategory Search(string name)
        {
            return categories.FirstOrDefault(x => x.Name == name);
        }
    }
}

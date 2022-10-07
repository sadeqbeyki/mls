using Framework.DAL;
using Microsoft.EntityFrameworkCore;
using MLS.Core.Contracts;
using MLS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.DAL.EF.Repositories
{
    public class EFProductCategoryRepository : RepositoryBase<long, ProductCategory>, IProductCategoryRepository
    {
        private static List<ProductCategory> categories = new List<ProductCategory>();

        public EFProductCategoryRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public ProductCategory Search(string name)
        {
            return categories.FirstOrDefault(x => x.Name == name);
        }
    }
}

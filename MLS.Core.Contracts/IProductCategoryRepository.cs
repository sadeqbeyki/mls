using MLS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLS.Core.Contracts
{
    public interface IProductCategoryRepository
    {
        void Create(ProductCategory productCategory);
        ProductCategory Search(string name);
    }
}

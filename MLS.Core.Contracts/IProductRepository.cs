using MLS.Core.Entities;

namespace MLS.Core.Contracts
{
    public interface IProductRepository
    {
        void Add(Product product);
        Product Search(string name);
    }
}
using MLS.Core.Entities;

namespace MLS.Core.Contracts
{
    public interface ITaskRepository
    {
        void Add(Entities.Task product);
        Entities.Task Search(string name);
    }
}
using Framework.DAL;
using Microsoft.EntityFrameworkCore;
using MLS.Contracts.Interfaces.TodoLists;
using MLS.Core.Entities;

namespace MLS.Infrastructure.Repositories
{
    public class EFTodoListRepository : RepositoryBase<long, TodoList>, ITodoListRepository
    {
        private static List<TodoList> TodoLists = new List<TodoList>();

        public EFTodoListRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}

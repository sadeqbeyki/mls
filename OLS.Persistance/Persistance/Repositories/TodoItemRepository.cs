using AppFramework.Application;
using AppFramework.Infrastructure;
using Microsoft.EntityFrameworkCore;
using OLS.Domain.Contracts.TodoItems;
using OLS.Domain.Entities;

namespace OLS.Persistance.Persistance.Repositories
{
    public class TodoItemRepository : BaseRepository<long, TodoItem>, ITodoItemRepository
    {
        //public TodoItemRepository(TodoContext dbContext) : base(dbContext)
        //{
        //}

        private readonly TodoContext _todoContext;

        public TodoItemRepository(TodoContext todoContext) : base(todoContext)
        {
            _todoContext = todoContext;
        }

        public OperationResult Add(TodoItem item)
        {
            var operation = new OperationResult();

            TodoItem todoItem = new()
            {
                Title = item.Title,
                Note = item.Note,
                ListId = item.ListId,
            };
            Create(todoItem);
            
            return operation.Succeeded();
        }

        public OperationResult Edit(UpdateTodoItem todoItem)
        {
            var operation = new OperationResult();
            var item = GetItemWithList(todoItem.Id);
            if (item == null)
                return operation.Failed(ApplicationMessages.RecordNotFound);

            item.Edit(todoItem.Title, todoItem.Note, todoItem.ListId);
            _todoContext.SaveChanges();
            return operation.Succeeded();
        }

        public UpdateTodoItem GetDetails(long id)
        {
            return _todoContext.TodoItems
                .Select(x => new UpdateTodoItem
            {
                Id = x.Id,
                Title = x.Title,
                Note = x.Note,
                ListId = x.ListId,
            }).FirstOrDefault(x => x.Id == id);
        }

        public TodoItem GetItemWithList(long id)
        {
            return _todoContext.TodoItems
                .Include(x => x.ListName)
                .FirstOrDefault(x => x.Id == id);
        }
    }
}
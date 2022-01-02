using Ardalis.Result;
using System.Collections.Generic;
using System.Threading.Tasks;
using waas.doro.Core.ProjectAggregate;

namespace waas.doro.Core.Interfaces
{
    public interface IToDoItemSearchService
    {
        Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
        Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
    }
}

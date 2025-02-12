using Models;

namespace Repositories
{
    public interface INotebookRepository
    {
        Task<List<Notebook>> GetAllNotebooksAsync();
        Task<Notebook> GetNotebookByIdAsync(Guid notebookId);
        Task AddNotebookAsync(Notebook notebook);
        Task UpdateNotebookAsync(Notebook notebook);
        Task DeleteNotebookAsync(Guid notebookId);
    }
}

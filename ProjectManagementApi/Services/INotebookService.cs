using ProjectManagementApi.Models;
using ProjectManagementApi.Dtos;

namespace Services
{
    public interface INotebookService
    {
        Task<List<Notebook>> GetAllNotebooksAsync(Guid userId);
        Task<Notebook> GetNotebookByIdAsync(Guid id);
        Task<Notebook> CreateNotebookAsync(Guid userId, CreateNotebookRequest request);
        Task<Notebook> UpdateNotebookAsync(Guid id, UpdateNotebookRequest request);
        Task DeleteNotebookAsync(Guid id);
    }
}

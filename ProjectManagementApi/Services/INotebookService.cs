using DTOs;

namespace Services
{
    public interface INotebookService
    {
        Task<List<NotebookDTO>> GetAllNotebooksAsync(Guid userId);
        Task<NotebookDTO> GetNotebookByIdAsync(Guid id);
        Task<NotebookDTO> CreateNotebookAsync(Guid userId, CreateNotebookRequest request);
        Task<NotebookDTO> UpdateNotebookAsync(Guid id, UpdateNotebookRequest request);
        Task DeleteNotebookAsync(Guid id);
    }
}

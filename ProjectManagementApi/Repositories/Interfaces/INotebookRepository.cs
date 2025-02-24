using ProjectManagementApi.Models;

namespace ProjectManagementApi.Repositories.Interfaces
{
    public interface INotebookRepository
    {
        Task<List<Notebook>> GetAllAsync();
        Task<Notebook> GetAsync(Guid notebookId);
        Task<Notebook> CreateAsync(Notebook notebook);
        Task<Notebook> UpdateAsync(Notebook notebook);
        Task DeleteAsync(Guid notebookId);
    }   
}

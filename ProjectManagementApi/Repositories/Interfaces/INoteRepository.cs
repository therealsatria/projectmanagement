using ProjectManagementApi.Models;

namespace ProjectManagementApi.Repositories.Interfaces
{
    public interface INoteRepository
    {
        Task<List<Note>> GetAllAsync();
        Task<Note> GetByIdAsync(Guid noteId);
        Task AddAsync(Note note);
        Task UpdateAsync(Note note);
        Task DeleteAsync(Guid noteId);
    }
}

using ProjectManagementApi.Models;

namespace ProjectManagementApi.Repositories.Interfaces
{
    public interface INoteRepository
    {
        Task<List<Note>> GetAllAsync();
        Task<Note> GetByIdAsync(Guid noteId);
        Task<Note> CreateAsync(Note note);
        Task<Note> UpdateAsync(Note note);
        Task DeleteAsync(Guid noteId);
    }
}

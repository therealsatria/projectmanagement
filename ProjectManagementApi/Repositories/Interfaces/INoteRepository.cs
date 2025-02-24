using ProjectManagementApi.Models;

namespace ProjectManagementApi.Repositories.Interfaces
{
    public interface INoteRepository
    {
        Task<List<Note>> GetAllNotesAsync();
        Task<Note> GetNoteByIdAsync(Guid noteId);
        Task AddNoteAsync(Note note);
        Task UpdateNoteAsync(Note note);
        Task DeleteNoteAsync(Guid noteId);
    }
}

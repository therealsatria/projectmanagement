using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Repositories
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

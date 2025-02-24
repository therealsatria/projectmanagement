using Microsoft.EntityFrameworkCore;
using ProjectManagementApi.Models;
using ProjectManagementApi.Data;
using ProjectManagementApi.Repositories.Interfaces;

namespace ProjectManagementApi.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly AppDbContext _context;

        public NoteRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Note>> GetAllNotesAsync()
        {
            return await _context.Notes.ToListAsync();
        }

        public async Task<Note> GetNoteByIdAsync(Guid noteId)
        {
            return await _context.Notes.FindAsync(noteId);
        }

        public async Task AddNoteAsync(Note note)
        {
            await _context.Notes.AddAsync(note);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateNoteAsync(Note note)
        {
            _context.Notes.Update(note);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteNoteAsync(Guid noteId)
        {
            var note = await _context.Notes.FindAsync(noteId);
            if (note != null)
            {
                _context.Notes.Remove(note);
                await _context.SaveChangesAsync();
            }
        }
    }
}

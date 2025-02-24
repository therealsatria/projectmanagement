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
        public async Task<List<Note>> GetAllAsync()
        {
            return await _context.Notes.ToListAsync();
        }
        public async Task<Note> GetAsync(Guid noteId)
        {
            return await _context.Notes.FindAsync(noteId);
        }
        public async Task<Note> CreateAsync(Note note)
        {
            _context.Notes.Add(note);
            await _context.SaveChangesAsync();
            return note;
        }
        public async Task<Note> UpdateAsync(Note note)
        {
            note.ModifiedOn = DateTime.Now;
            _context.Notes.Update(note);
            await _context.SaveChangesAsync();
            return note;
        }
        public async Task DeleteAsync(Guid noteId)
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

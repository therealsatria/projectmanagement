using Microsoft.EntityFrameworkCore;
using Models;
using Data;

namespace Repositories
{
    public class NotebookRepository : INotebookRepository
    {
        private readonly AppDbContext _context;

        public NotebookRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Notebook>> GetAllNotebooksAsync()
        {
            return await _context.Notebooks.ToListAsync();
        }

        public async Task<Notebook> GetNotebookByIdAsync(Guid notebookId)
        {
            return await _context.Notebooks.FindAsync(notebookId);
        }

        public async Task AddNotebookAsync(Notebook notebook)
        {
            await _context.Notebooks.AddAsync(notebook);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateNotebookAsync(Notebook notebook)
        {
            _context.Notebooks.Update(notebook);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteNotebookAsync(Guid notebookId)
        {
            var notebook = await _context.Notebooks.FindAsync(notebookId);
            if (notebook != null)
            {
                _context.Notebooks.Remove(notebook);
                await _context.SaveChangesAsync();
            }
        }
    }
}

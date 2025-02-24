using Microsoft.EntityFrameworkCore;
using ProjectManagementApi.Models;
using ProjectManagementApi.Data;
using ProjectManagementApi.Repositories.Interfaces;

namespace ProjectManagementApi.Repositories
{
    public class NotebookRepository : INotebookRepository
    {
        private readonly AppDbContext _context;

        public NotebookRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Notebook>> GetAllAsync()
        {
            return await _context.Notebooks.ToListAsync();
        }
        public async Task<Notebook> GetByIdAsync(Guid notebookId)
        {
            return await _context.Notebooks.FindAsync(notebookId);
        }
        public async Task<Notebook> CreateAsync(Notebook notebook)
        {
            _context.Notebooks.Add(notebook);
            await _context.SaveChangesAsync();
            return notebook;
        }
        public async Task<Notebook> UpdateAsync(Notebook notebook)
        {
            notebook.ModifiedOn = DateTime.Now;
            _context.Notebooks.Update(notebook);
            await _context.SaveChangesAsync();
            return notebook;
        }
        public async Task DeleteAsync(Guid notebookId)
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

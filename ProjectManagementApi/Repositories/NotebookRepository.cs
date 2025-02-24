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

        
    }
}

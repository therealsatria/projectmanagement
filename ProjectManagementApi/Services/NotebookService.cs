using ProjectManagementApi.Dtos;
using ProjectManagementApi.Models;
using ProjectManagementApi.Services.interfaces;
using ProjectManagementApi.Repositories.Interfaces;

namespace Services
{
    public class NotebookService : INotebookService
    {
        private readonly INotebookRepository _notebookRepository;
        private readonly IUserRepository _userRepository;

        public NotebookService(INotebookRepository notebookRepository, IUserRepository userRepository)
        {
            _notebookRepository = notebookRepository;
            _userRepository = userRepository;
        }

        public Task<Notebook> CreateNotebookAsync(Guid userId, CreateNotebookRequest request)
        {
            throw new NotImplementedException();
        }

        public Task DeleteNotebookAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Notebook>> GetAllNotebooksAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<Notebook> GetNotebookByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Notebook> UpdateNotebookAsync(Guid id, UpdateNotebookRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
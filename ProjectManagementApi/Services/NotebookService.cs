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

        
    }
}
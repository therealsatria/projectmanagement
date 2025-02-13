using Models;
using Repositories;
using DTOs;

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
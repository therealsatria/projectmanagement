using ProjectManagementApi.Models;

namespace ProjectManagementApi.Repositories.Interfaces
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAllAsync();
        Task<Project> GetByIdAsync(Guid projectId);
        Task<Project> CreateAsync(Project project);
        Task UpdateAsync(Project project);
        Task DeleteAsync(Guid projectId);
    }
}
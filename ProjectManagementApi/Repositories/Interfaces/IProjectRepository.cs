using ProjectManagementApi.Models;

namespace ProjectManagementApi.Repositories.Interfaces
{
    public interface IProjectRepository
    {
        Task<List<Project>> GetAllAsync();
        Task<Project> GetAsync(Guid projectId);
        Task<Project> CreateAsync(Project project);
        Task<Project> UpdateAsync(Project project);
        Task DeleteAsync(Guid projectId);
    }
}
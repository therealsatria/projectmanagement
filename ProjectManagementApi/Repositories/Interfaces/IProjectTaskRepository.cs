using ProjectManagementApi.Models;

namespace ProjectManagementApi.Repositories.Interfaces
{
    public interface IProjectTaskRepository
    {
        Task<List<ProjectTask>> GetAllAsync();
        Task<ProjectTask> GetByIdAsync(Guid projectTaskId);
        Task<ProjectTask> CreateAsync(ProjectTask projectTask);
        Task UpdateAsync(ProjectTask projectTask);
        Task DeleteAsync(Guid projectTaskId);
    }
}
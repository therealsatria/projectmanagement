using ProjectManagementApi.Models;

namespace ProjectManagementApi.Repositories.Interfaces
{
    public interface IProjectTaskRepository
    {
        Task<List<ProjectTask>> GetAllAsync();
        Task<ProjectTask> GetAsync(Guid projectTaskId);
        Task<ProjectTask> CreateAsync(ProjectTask projectTask);
        Task<ProjectTask> UpdateAsync(ProjectTask projectTask);
        Task DeleteAsync(Guid projectTaskId);
    }
}
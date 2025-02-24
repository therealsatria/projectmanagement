using ProjectManagementApi.Models;

namespace ProjectManagementApi.Repositories.Interfaces
{
    public interface IActivityLogRepository
    {
        Task<List<ActivityLog>> GetAllAsync();
        Task<ActivityLog> GetByIdAsync(Guid activityLogId);
        Task<ActivityLog> CreateAsync(ActivityLog activityLog);
        Task UpdateAsync(ActivityLog activityLog);
        Task DeleteAsync(Guid activityLogId);
    }
}
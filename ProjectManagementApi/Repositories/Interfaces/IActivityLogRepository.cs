using ProjectManagementApi.Models;

namespace ProjectManagementApi.Repositories.Interfaces
{
    public interface IActivityLogRepository
    {
        Task<List<ActivityLog>> GetAllAsync();
        Task<ActivityLog> GetAsync(Guid activityLogId);
        Task<ActivityLog> CreateAsync(ActivityLog activityLog);
        Task DeleteAsync(Guid activityLogId);
    }
}
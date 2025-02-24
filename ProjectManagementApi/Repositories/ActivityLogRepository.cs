using Microsoft.EntityFrameworkCore;
using ProjectManagementApi.Models;
using ProjectManagementApi.Data;
using ProjectManagementApi.Repositories.Interfaces;

namespace ProjectManagementApi.Repositories
{
    public class ActivityLogRepository : IActivityLogRepository
    {
        private readonly AppDbContext _context;
        public ActivityLogRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<ActivityLog>> GetAllAsync()
        {
            return await _context.ActivityLogs.ToListAsync();
        }
        public async Task<ActivityLog> GetAsync(Guid ActivityLogId)
        {
            return await _context.ActivityLogs.FindAsync(ActivityLogId);
        }
        public async Task<ActivityLog> CreateAsync(ActivityLog activityLog)
        {
            _context.ActivityLogs.Add(activityLog);
            await _context.SaveChangesAsync();
            return activityLog;
        }
        public async Task DeleteAsync(Guid ActivityLogId)
        {
            var activityLog = await _context.ActivityLogs.FindAsync(ActivityLogId);
            if (activityLog != null)
            {
                _context.ActivityLogs.Remove(activityLog);
                await _context.SaveChangesAsync();
            }
        }
    }
}
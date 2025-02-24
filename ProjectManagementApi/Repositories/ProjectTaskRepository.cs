using Microsoft.EntityFrameworkCore;
using ProjectManagementApi.Models;
using ProjectManagementApi.Data;
using ProjectManagementApi.Repositories.Interfaces;

namespace ProjectManagementApi.Repositories
{
    public class ProjectTaskRepository : IProjectTaskRepository
    {
        private readonly AppDbContext _context;
        public ProjectTaskRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<ProjectTask>> GetAllAsync()
        {
            return await _context.ProjectTasks.ToListAsync();
        }
        public async Task<ProjectTask> GetByIdAsync(Guid projectTaskId)
        {
            return await _context.ProjectTasks.FindAsync(projectTaskId);
        }
        public async Task<ProjectTask> CreateAsync(ProjectTask projectTask)
        {
            _context.ProjectTasks.Add(projectTask);
            await _context.SaveChangesAsync();
            return projectTask;
        }
        public async Task<ProjectTask> UpdateAsync(ProjectTask projectTask)
        {
            projectTask.ModifiedOn = DateTime.Now;
            _context.ProjectTasks.Update(projectTask);
            await _context.SaveChangesAsync();
            return projectTask;
        }
        public async Task DeleteAsync(Guid projectTaskId)
        {
            var projectTask = await _context.ProjectTasks.FindAsync(projectTaskId);
            if (projectTask!= null)
            {
                _context.ProjectTasks.Remove(projectTask);
                await _context.SaveChangesAsync();
            }
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Notebook> Notebooks { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ActivityLog> ActivityLogs { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User relationships
            modelBuilder.Entity<User>()
                .HasMany(u => u.Notebooks)
                .WithOne(n => n.User)
                .HasForeignKey(n => n.UserId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Projects)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Comments)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.AssignedTasks)
                .WithOne(t => t.Assignee)
                .HasForeignKey(t => t.AssigneeId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.ActivityLogs)
                .WithOne(l => l.User)
                .HasForeignKey(l => l.UserId);

            // Notebook relationships
            modelBuilder.Entity<Notebook>()
                .HasMany(n => n.Notes)
                .WithOne(n => n.Notebook)
                .HasForeignKey(n => n.NotebookId);

            // Project relationships
            modelBuilder.Entity<Project>()
                .HasMany(p => p.Boards)
                .WithOne(b => b.Project)
                .HasForeignKey(b => b.ProjectId);

            // Board relationships
            modelBuilder.Entity<Board>()
                .HasMany(b => b.Tasks)
                .WithOne(t => t.Board)
                .HasForeignKey(t => t.BoardId);

            // Task relationships
            modelBuilder.Entity<Models.Task>()
                .HasMany(m => m.Comments)
                .WithOne(c => c.Task)
                .HasForeignKey(c => c.TaskId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
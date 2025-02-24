using Microsoft.EntityFrameworkCore;
using ProjectManagementApi.Models;
using ProjectManagementApi.Data;
using ProjectManagementApi.Repositories.Interfaces;

namespace ProjectManagementApi.Repositories{
    public class CommentRepository : ICommentRepository
    {
        private readonly AppDbContext _context;
        public CommentRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Comment>> GetAllAsync()
        {
            return await _context.Comments.ToListAsync();
        }
        public async Task<Comment> GetByIdAsync(Guid commentId)
        {
            return await _context.Comments.FindAsync(commentId);
        }
        public async Task<Comment> CreateAsync(Comment comment)
        {
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
            return comment;
        }
        public async Task<Comment> UpdateAsync(Comment comment)
        {
            comment.ModifiedOn = DateTime.Now;
            _context.Comments.Update(comment);
            await _context.SaveChangesAsync();
            return comment;
        }
        public async Task DeleteAsync(Guid commentId)
        {
            var comment = await _context.Comments.FindAsync(commentId);
            if (comment!= null)
            {
                _context.Comments.Remove(comment);
                await _context.SaveChangesAsync();
            }
        }
    }
}
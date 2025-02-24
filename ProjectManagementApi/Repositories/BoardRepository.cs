using Microsoft.EntityFrameworkCore;
using ProjectManagementApi.Models;
using ProjectManagementApi.Data;
using ProjectManagementApi.Repositories.Interfaces;

namespace ProjectManagementApi.Repositories
{
    public class BoardRepository : IBoardRepository
    {
        private readonly AppDbContext _context;
        public BoardRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Board>> GetAllAsync()
        {
            return await _context.Boards.ToListAsync();
        }
        public async Task<Board> GetByIdAsync(Guid boardId)
        {
            return await _context.Boards.FindAsync(boardId);
        }
        public async Task<Board> CreateAsync(Board board)
        {
            _context.Boards.Add(board);
            await _context.SaveChangesAsync();
            return board;
        }
        public async Task<Board> UpdateAsync(Board board)
        {
            board.ModifiedOn = DateTime.Now;
            _context.Boards.Update(board);
            await _context.SaveChangesAsync();
            return board;
        }
        public async Task DeleteAsync(Guid boardId)
        {
            var board = await _context.Boards.FindAsync(boardId);
            if (board!= null)
            {
                _context.Boards.Remove(board);
                await _context.SaveChangesAsync();
            }
        }
    }
}
using ProjectManagementApi.Models;

namespace ProjectManagementApi.Repositories.Interfaces
{
    public interface IBoardRepository
    {
        Task<List<Board>> GetAllAsync();
        Task<Board> GetByIdAsync(Guid boardId);
        Task<Board> CreateAsync(Board board);
        Task UpdateAsync(Board board);
        Task DeleteAsync(Guid boardId);
    }
}
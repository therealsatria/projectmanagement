using ProjectManagementApi.Models;

namespace ProjectManagementApi.Repositories.Interfaces
{
    public interface IBoardRepository
    {
        Task<List<Board>> GetAllAsync();
        Task<Board> GetAsync(Guid boardId);
        Task<Board> CreateAsync(Board board);
        Task<Board> UpdateAsync(Board board);
        Task DeleteAsync(Guid boardId);
    }
}
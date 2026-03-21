using SkillMDFileDemo.Domain.Entities;

namespace SkillMDFileDemo.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(int id);
    }
}
using Microsoft.EntityFrameworkCore;
using SkillMDFileDemo.Domain.Entities;
using SkillMDFileDemo.Domain.Repositories;

namespace SkillMDFileDemo.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly SkillMDFileDbContext _context;

        public ProductRepository(SkillMDFileDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}


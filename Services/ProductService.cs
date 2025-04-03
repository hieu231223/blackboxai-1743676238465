using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YourProjectName.Data;
using YourProjectName.Models;

namespace YourProjectName.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<HangHoa>> GetAllProductsAsync()
        {
            return await _context.HangHoas
                .Include(h => h.LoaiHang)
                .Where(h => h.Gia >= 100)
                .ToListAsync();
        }

        public async Task<List<HangHoa>> GetProductsByCategoryAsync(int categoryId)
        {
            return await _context.HangHoas
                .Include(h => h.LoaiHang)
                .Where(h => h.LoaiHangId == categoryId && h.Gia >= 100)
                .ToListAsync();
        }

        public async Task CreateProductAsync(HangHoa product)
        {
            _context.HangHoas.Add(product);
            await _context.SaveChangesAsync();
        }
    }
}
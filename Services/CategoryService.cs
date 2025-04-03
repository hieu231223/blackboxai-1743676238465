using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YourProjectName.Data;
using YourProjectName.Models;

namespace YourProjectName.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<LoaiHang>> GetAllCategoriesAsync()
        {
            return await _context.LoaiHangs.ToListAsync();
        }

        public async Task<LoaiHang> GetCategoryByIdAsync(int id)
        {
            return await _context.LoaiHangs.FindAsync(id);
        }
    }
}
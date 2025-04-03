using System.Collections.Generic;
using System.Threading.Tasks;
using YourProjectName.Models;

namespace YourProjectName.Services
{
    public interface ICategoryService
    {
        Task<List<LoaiHang>> GetAllCategoriesAsync();
        Task<LoaiHang> GetCategoryByIdAsync(int id);
    }
}
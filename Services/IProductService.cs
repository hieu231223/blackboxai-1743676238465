using System.Collections.Generic;
using System.Threading.Tasks;
using YourProjectName.Models;

namespace YourProjectName.Services
{
    public interface IProductService
    {
        Task<List<HangHoa>> GetAllProductsAsync();
        Task<List<HangHoa>> GetProductsByCategoryAsync(int categoryId);
        Task CreateProductAsync(HangHoa product);
    }
}
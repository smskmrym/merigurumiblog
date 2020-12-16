using System.Collections.Generic;
using System.Threading.Tasks;
using merigurumiblogFront.Models;

namespace merigurumiblogFront.ApiServices.Interfaces
{
    public interface IBlogApiService
    {
        Task<List<BlogListModel>> GetAllAsync();
        Task<BlogListModel> GetByIdAsync(int id);
        Task<List<BlogListModel>> GetAllByCategoryIdAsync(int id);
    }
}
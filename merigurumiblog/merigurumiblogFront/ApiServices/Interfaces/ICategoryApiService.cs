using System.Collections.Generic;
using System.Threading.Tasks;
using merigurumiblogFront.Models;

namespace merigurumiblogFront.ApiServices.Interfaces{
    public interface ICategoryApiService
    {
        Task<List<CategoryListModel>> GetAllAsync();
    }
}
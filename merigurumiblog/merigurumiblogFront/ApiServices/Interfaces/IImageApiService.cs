using System.Threading.Tasks;

namespace merigurumiblogFront.ApiServices.Interfaces{
    public interface IImageApiService
    {
        Task<string> GetBlogImageByIdAsync(int id);
    }
}
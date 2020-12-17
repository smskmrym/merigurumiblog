using System.Threading.Tasks;
using merigurumiblogFront.Models;

namespace merigurumiblogFront.ApiServices.Interfaces{
    public interface IAuthApiService
    {
        Task<bool> SignIn(AppUserLoginModel model);
    }
}
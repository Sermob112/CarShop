using System.Security.Claims;
using System.Threading.Tasks;
using CarShop.Domain.Response;
using CarShop.Domain.ViewModels.Account;

namespace CarShop.Service.Interfaces
{
    public interface IAccountService
    {
        //привязать интерфес и сущность в initializer!!!!!!!!!!!!!
        Task<BaseResponse<ClaimsIdentity>> Register(RegisterViewModel model);

        Task<BaseResponse<ClaimsIdentity>> Login(LoginViewModel model);

        Task<BaseResponse<bool>> ChangePassword(ChangePasswordViewModel model);
    }
}
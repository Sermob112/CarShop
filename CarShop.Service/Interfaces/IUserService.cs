using System.Collections.Generic;
using System.Threading.Tasks;
using CarShop.Domain.Entity;
using CarShop.Domain.Response;
using CarShop.Domain.ViewModels.User;

namespace CarShop.Service.Interfaces
{
    public interface IUserService
    {
        Task<IBaseResponse<User>> Create(UserViewModel model);
        
        BaseResponse<Dictionary<int, string>> GetRoles();
        
        Task<BaseResponse<IEnumerable<UserViewModel>>> GetUsers();
        
        Task<IBaseResponse<bool>> DeleteUser(long id);
    }
}
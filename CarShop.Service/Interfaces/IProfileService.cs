using System.Collections.Generic;
using System.Threading.Tasks;
using CarShop.Domain.Entity;
using CarShop.Domain.Response;
using CarShop.Domain.ViewModels.Profile;
using CarShop.Domain.ViewModels.User;

namespace CarShop.Service.Interfaces
{
    public interface IProfileService
    {
        Task<BaseResponse<ProfileViewModel>> GetProfile(string userName);

        Task<BaseResponse<Profile>> Save(ProfileViewModel model);
    }
}
using CarShop.DAL.Interfaces;
using CarShop.DAL.Repositories;
using CarShop.Domain.Entity;
using CarShop.Service.Implementations;
using CarShop.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CarShop
{
    public static class Initializer
    {
        public static void InitializeRepositories(this IServiceCollection services)
        {
/*            services.AddScoped<IBaseRepository<Car>, CarRepository>();*/
            services.AddScoped<IBaseRepository<User>, UserRepository>();
            services.AddScoped<IBaseRepository<Profile>, ProfileRepository>();
        /*    services.AddScoped<IBaseRepository<Basket>, BasketRepository>();
            services.AddScoped<IBaseRepository<Order>, OrderRepository>();*/
            services.AddScoped<IBaseRepository<Place>, PlaceRepository>();
        }

        public static void InitializeServices(this IServiceCollection services)
        {
           /* services.AddScoped<ICarService, CarService>();*/
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProfileService, ProfileService>();
            /*  services.AddScoped<IBasketService, BasketService>();*/
            services.AddScoped<IPlaceService, PlaceService>();
 /*           services.AddScoped<IOrderService, OrderService>();*/
        }
    }
}
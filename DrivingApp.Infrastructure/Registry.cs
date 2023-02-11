
using DrivingApp.Infrastructure.Interfaces;
using DrivingApp.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;


namespace DrivingApp.Infrastructure
{
    public static class Registry
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ICitiesRepository, CitiesRepository>();
            services.AddScoped<IConditionsRepository, ConditionsRepository>();
            services.AddScoped<ICountriesRepository, CountriesRepository>();
            services.AddScoped<IMileStonesRepository, MileStonesRepository>();
            services.AddScoped<IPhotosRepository, PhotosRepository>();
            services.AddScoped<IRideConditionsRepository, RideConditionsRepository>();
            services.AddScoped<IRidesRepository, RidesRepository>();
            services.AddScoped<IUserRideCommentsRepository, UserRideCommentsRepository>();
            services.AddScoped<IUserRidesRepository, UserRidesRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<IVehiclesRepository, VehiclesRepository>();
        }
    }
}

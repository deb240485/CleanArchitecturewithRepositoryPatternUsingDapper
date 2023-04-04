using CleanArchitecture.Application;
using CleanArchitecture.Application.Contracts;
using CleanArchitecture.Infrastructure.Context;
using CleanArchitecture.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterService(this IServiceCollection services)
        {
            services.AddSingleton<DapperContext>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}

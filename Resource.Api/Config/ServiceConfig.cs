using Microsoft.Extensions.DependencyInjection;
using Resource.Api.Services;
using System.Net.Http;

namespace Resource.Api.Config
{
    public static class ServiceConfig
    {
        public static IServiceCollection ConfigService(this IServiceCollection services)
        {
            services
               .AddTransient<HttpClient>()
               .AddTransient<IDogServiceProvider, DogServiceProvider>();

            return services;
        }
    }
}

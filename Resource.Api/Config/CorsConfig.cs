using Microsoft.Extensions.DependencyInjection;

namespace Resource.Api.Config
{
    public static class CorsConfig
    {
        public static IServiceCollection ConfigCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(
                    name: "AllowOrigin",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader();
                    });
            });

            return services;
        }
    }
}

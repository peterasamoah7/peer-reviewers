using Microsoft.Extensions.DependencyInjection;
using Search.Services;

namespace Search
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSearchUnit(this IServiceCollection services)
        {
            services.AddHttpClient<SearchService>(); 

            return services; 
        }
    }
}

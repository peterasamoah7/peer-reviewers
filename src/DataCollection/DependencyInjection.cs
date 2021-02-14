using DataCollection.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataCollection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataCollectionUnit(this IServiceCollection services)
        {
            services.AddHttpClient<KeyPhraseService>();
            services.AddHttpClient<TokenService>();
            services.AddScoped<ContentService>(); 

            return services; 
        }
    }
}

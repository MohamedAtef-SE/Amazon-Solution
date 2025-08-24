using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.DL.Extentions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDLServices(this IServiceCollection services)
        {
            // Here we can register DL related services to DI Container

            //services.AddScoped<IConfiguration>

            return services;
        }
    }
}

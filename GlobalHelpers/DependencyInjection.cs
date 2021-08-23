using GlobalHelpers.Helpers;
using GlobalHelpers.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using SharedConfig.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterGlobalHelpersLayer(this IServiceCollection services)
        {
            services.AddScoped<IGlobalHelperService, GlobalHelperService>();          
            return services;
        }
    }
}

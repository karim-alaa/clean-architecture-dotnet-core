﻿using Microsoft.Extensions.DependencyInjection;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterServiceLayer(this IServiceCollection services)
        {
            services.AddTransient<IBookService, BookService>();           
            return services;
        }
    }
}

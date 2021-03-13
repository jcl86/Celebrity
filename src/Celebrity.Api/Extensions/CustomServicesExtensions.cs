﻿using System;
using System.Reflection;
using System.Linq;
using Celebrity;
using Celebrity.Data;
using Celebrity.Repositories;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class CustomServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            var assembly = typeof(ConceptName).Assembly;
            var types = assembly.GetTypes().
                Where(t => t.IsService());
            foreach (var serviceType in types)
            {
                services.AddScoped(serviceType);
            }

            return services;
        }

        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            //services.AddScoped<Random>();
            //services.AddScoped<IRandomProvider, RandomProvider>();
            services.AddScoped<IUnitOfWork, CelebrityContext>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ISubcategoryRepository, SubcategoryRepository>();
            services.AddScoped<IGameRepository, GameRepository>();
            services.AddScoped<IConceptRepository, ConceptRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}

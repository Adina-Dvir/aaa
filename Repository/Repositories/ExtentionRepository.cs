using Microsoft.Extensions.DependencyInjection;
using Repository.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public static class ExtentionRepository
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            
            services.AddScoped<IRepository<Category>,CategoryRepository>();
            services.AddScoped<IRepository<User>,UserRepository>();
            //...כאן נגדיר את כל התלויות של הrepository
           // services.AddScoped < IRepository < Product > ProductRepository > ();
            return services;
        }
    }
}

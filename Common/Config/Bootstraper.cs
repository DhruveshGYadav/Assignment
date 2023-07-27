using Common.Repositories;
using Common.Repositories.Interfaces;
using Common.Services;
using Common.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Config
{
    public static class Bootstraper
    {
        public static void RegisterDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            string ConnectionString = configuration.GetConnectionString("DbConnection");
            services.AddDbContext<EFContext>(option => option.UseSqlServer(ConnectionString));
        }
        public static void RegiserRepoService(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IUserSerice, UserService>();
        }

    }
}

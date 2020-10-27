using Books.Repositorio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Books.Infra
{
    public static class DbContextExtensionApi
    {
        public static void AddDbContextConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VolumeContexto>(options =>
                options.UseSqlite(configuration.GetConnectionString("SqliteConnectionString"), a => a.MigrationsAssembly("Books.Api"))
            );
        }
    }
}

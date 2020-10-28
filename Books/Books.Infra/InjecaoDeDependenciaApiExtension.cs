using Books.Dominio.Interfaces;
using Books.Dominio.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Books.Infra
{
    public static class InjecaoDeDependenciaApiExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<IBooksService, BooksService>();
        }
    }
}

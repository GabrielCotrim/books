using Books.Dominio.Interfaces;
using Books.Dominio.Services;
using Books.Repositorio;
using Books.Repositorio.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Books.Infra
{
    public static class InjecaoDeDependenciaApiExtension
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<IRepositorioDeVolume, RepositorioDeVolume>();

            services.AddScoped<IBooksService, BooksService>();
        }
    }
}

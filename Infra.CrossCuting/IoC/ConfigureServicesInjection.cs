using Dominio.Interfaces.Repositorio.TodoAppRepositorio;
using Dominio.Interfaces.Repositorio.TodoAppService;
using Infra.Data.Contexto;
using Infra.Data.Repositorio.TodoAppRepositorio;
using Microsoft.Extensions.DependencyInjection;
using Service;

namespace Infra.CrossCuting.IoC
{
    public static class ConfigureServicesInjection
    {
        public static void AddInjectionContext(this IServiceCollection services)
        {
            services.AddScoped<AppContexto>();
        }

        public static void AddInjectionService(this IServiceCollection services)
        {
            services.AddScoped<ITodoAppService, TodoAppService>();
        }

        public static void AddInjectionRepositorio(this IServiceCollection services)
        {
            services.AddScoped<ICadastroRepositorio, CadastroRepositorio>();
        }
    }
}

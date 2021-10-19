using LeakGas.Business.Interfaces;
using LeakGas.Business.Interfaces.Data;
using LeakGas.Business.Notificacoes;
using LeakGas.Data.Context;
using LeakGas.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeakGas.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<LeakGasContext>();

            services.AddScoped<INotificador, Notificador>();

            #region Repos
            services.AddScoped<ILoginRepository, LoginRepository>();
            services.AddScoped<IOcorrenciaRepository, OcorrenciaRepository>();
            services.AddScoped<ICondominioRepository, CondominioRepository>();
            services.AddScoped<IUsuarioApartamentoRepository, UsuarioApartamentoRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            #endregion

            return services;
        }
    }
}

using CGJ.Application.Auditorias.Service;
using CGJ.Application.Auditorias.Service.Interface;
using CGJ.Application.Clientes.Service;
using CGJ.Application.Clientes.Service.Interfaces;
using CGJ.Application.Consultas.Service;
using CGJ.Application.Consultas.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CGJ.Application
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ConfigurationModule).Assembly);

            #region Clientes
            services.AddScoped(typeof(IClienteService<,,,>), typeof(ClienteService));
            services.AddScoped(typeof(ITelefoneService<,,,>), typeof(TelefoneService));
            services.AddScoped(typeof(IUsuarioService<,,,>), typeof(UsuarioService));
            #endregion

            #region Consultas
            services.AddScoped(typeof(IAuditoriaService<,,,>), typeof(AuditoriaService));
            services.AddScoped(typeof(IConsultaService<,,,>), typeof(ConsultaService));
            services.AddScoped(typeof(IContratoService<,,,>), typeof(ContratoService));
            services.AddScoped(typeof(IFornecedorService<,,,>), typeof(FornecedorService));
            services.AddScoped(typeof(IOperacaoService<,,,>), typeof(OperacaoService));
            services.AddScoped(typeof(IPlanoService<,,,>), typeof(PlanoService));
            #endregion

            return services;
        }
    }
}

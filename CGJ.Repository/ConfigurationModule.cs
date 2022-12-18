using CGJ.Domain.Auditorias.Repository;
using CGJ.Domain.Clientes.Repository;
using CGJ.Domain.Consultas.Repository;
using CGJ.Repository.Context;
using CGJ.Repository.Database;
using CGJ.Repository.Repository.Auditorias;
using CGJ.Repository.Repository.Clientes;
using CGJ.Repository.Repository.Consultas;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CGJ.Repository
{
    public static class ConfigurationModule
    {
        public static IServiceCollection RegisterRepository(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<CGJContext>(c =>
            {
                c.UseSqlServer(connectionString);
            });

            services.AddScoped(typeof(Repository<>));

            #region Clientes
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<ITelefoneRepository, TelefoneRepository>();
            #endregion

            #region Consultas
            services.AddScoped<IConsultaRepository, ConsultaRepository>();
            services.AddScoped<IContratoRepository, ContratoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IOperacaoRepository, OperacaoRepository>();
            services.AddScoped<IPlanoRepository, PlanoRepository>();
            #endregion

            #region Auditorias
            services.AddScoped<IAuditoriaRepository, AuditoriaRepository>();
            #endregion

            return services;
        }
    }
}

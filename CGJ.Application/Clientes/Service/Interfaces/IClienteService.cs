using CGJ.Infra.Service;

namespace CGJ.Application.Clientes.Service.Interfaces
{
    public interface IClienteService<TCodigo, TInput, TUpdate, TOutput> : IService<TCodigo, TInput, TUpdate, TOutput>
        where TInput : class
        where TUpdate : class
        where TOutput : class
    {
    }
}

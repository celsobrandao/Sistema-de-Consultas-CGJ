using CGJ.Infra.Service;

namespace CGJ.Application.Consultas.Service.Interfaces
{
    public interface IContratoService<TCodigo, TInput, TUpdate, TOutput> : IService<TCodigo, TInput, TUpdate, TOutput>
        where TInput : class
        where TUpdate : class
        where TOutput : class
    {
    }
}

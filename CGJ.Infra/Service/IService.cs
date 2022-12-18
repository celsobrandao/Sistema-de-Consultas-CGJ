namespace CGJ.Infra.Service
{
    public interface IService<TCodigo, TInput, TUpdate, TOutput>
        where TInput : class
        where TUpdate : class
        where TOutput : class
    {
        Task<TOutput> Criar(TInput dto);
        Task<TOutput> Atualizar(TUpdate dto);
        Task Remover(TCodigo codigo);
        Task<List<TOutput>> ObterTodos();
        Task<TOutput> ObterPorCodigo(TCodigo codigo);
    }
}

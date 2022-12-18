using AutoMapper;
using CGJ.Infra.Repository;
using CGJ.Infra.Service;

namespace CGJ.Application.Service
{
    public abstract class ServiceBase<TDomain, TCodigo, TInput, TUpdate, TOutput> : IService<TCodigo, TInput, TUpdate, TOutput>
        where TDomain : class
        where TInput : class
        where TUpdate : class
        where TOutput : class
    {
        protected readonly IRepository<TDomain> _repository;
        protected readonly IMapper _mapper;

        protected ServiceBase(IRepository<TDomain> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        protected TDomain InputDtoToDomain(TInput dto)
        {
            return _mapper.Map<TDomain>(dto);
        }

        protected TDomain UpdateDtoToDomain(TUpdate dto)
        {
            return _mapper.Map<TDomain>(dto);
        }

        protected TOutput DomainToDto(TDomain domain)
        {
            return _mapper.Map<TOutput>(domain);
        }

        public virtual async Task<TOutput> Criar(TInput dto)
        {
            var domain = InputDtoToDomain(dto);

            await _repository.Save(domain);

            return DomainToDto(domain);
        }

        public async Task<TOutput> Atualizar(TUpdate dto)
        {
            var domain = UpdateDtoToDomain(dto);

            await _repository.Update(domain);

            return DomainToDto(domain);
        }

        public async Task Remover(TCodigo codigo)
        {
            var cliente = await _repository.Get(codigo);

            await _repository.Delete(cliente);
        }

        public virtual async Task<List<TOutput>> ObterTodos()
        {
            var result = await _repository.GetAll();

            return _mapper.Map<List<TOutput>>(result);
        }

        public virtual async Task<TOutput> ObterPorCodigo(TCodigo codigo)
        {
            var result = await _repository.Get(codigo);

            return DomainToDto(result);
        }
    }
}

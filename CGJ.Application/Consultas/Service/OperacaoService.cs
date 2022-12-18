using AutoMapper;
using CGJ.Application.Consultas.DTO;
using CGJ.Application.Consultas.Service.Interfaces;
using CGJ.Application.Service;
using CGJ.Domain.Consultas;
using CGJ.Domain.Consultas.Repository;

namespace CGJ.Application.Consultas.Service
{
    public class OperacaoService : ServiceBase<Operacao, Guid, OperacaoInputDTO, OperacaoUpdateDTO, OperacaoOutputDTO>,
        IOperacaoService<Guid, OperacaoInputDTO, OperacaoUpdateDTO, OperacaoOutputDTO>
    {
        public OperacaoService(IOperacaoRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

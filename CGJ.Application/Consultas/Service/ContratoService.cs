using AutoMapper;
using CGJ.Application.Consultas.DTO;
using CGJ.Application.Consultas.Service.Interfaces;
using CGJ.Application.Service;
using CGJ.Domain.Consultas;
using CGJ.Domain.Consultas.Repository;

namespace CGJ.Application.Consultas.Service
{
    public class ContratoService : ServiceBase<Contrato, Guid, ContratoInputDTO, ContratoUpdateDTO, ContratoOutputDTO>,
        IContratoService<Guid, ContratoInputDTO, ContratoUpdateDTO, ContratoOutputDTO>
    {
        public ContratoService(IContratoRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

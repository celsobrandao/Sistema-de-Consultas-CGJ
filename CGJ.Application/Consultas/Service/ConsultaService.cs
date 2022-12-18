using AutoMapper;
using CGJ.Application.Consultas.DTO;
using CGJ.Application.Consultas.Service.Interfaces;
using CGJ.Application.Service;
using CGJ.Domain.Consultas;
using CGJ.Domain.Consultas.Repository;

namespace CGJ.Application.Consultas.Service
{
    public class ConsultaService : ServiceBase<Consulta, Guid, ConsultaInputDTO, ConsultaUpdateDTO, ConsultaOutputDTO>,
        IConsultaService<Guid, ConsultaInputDTO, ConsultaUpdateDTO, ConsultaOutputDTO>
    {
        public ConsultaService(IConsultaRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

using AutoMapper;
using CGJ.Application.Consultas.DTO;
using CGJ.Application.Consultas.Service.Interfaces;
using CGJ.Application.Service;
using CGJ.Domain.Consultas;
using CGJ.Domain.Consultas.Repository;

namespace CGJ.Application.Consultas.Service
{
    public class AuditoriaService : ServiceBase<Auditoria, Guid, AuditoriaInputDTO, AuditoriaUpdateDTO, AuditoriaOutputDTO>,
        IAuditoriaService<Guid, AuditoriaInputDTO, AuditoriaUpdateDTO, AuditoriaOutputDTO>
    {
        public AuditoriaService(IAuditoriaRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

using AutoMapper;
using CGJ.Application.Auditorias.DTO;
using CGJ.Application.Auditorias.Service.Interface;
using CGJ.Application.Service;
using CGJ.Domain.Auditorias;
using CGJ.Domain.Auditorias.Repository;

namespace CGJ.Application.Auditorias.Service
{
    public class AuditoriaService : ServiceBase<Auditoria, Guid, AuditoriaInputDTO, AuditoriaUpdateDTO, AuditoriaOutputDTO>,
        IAuditoriaService<Guid, AuditoriaInputDTO, AuditoriaUpdateDTO, AuditoriaOutputDTO>
    {
        public AuditoriaService(IAuditoriaRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

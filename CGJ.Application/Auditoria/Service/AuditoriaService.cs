using AutoMapper;
using CGJ.Application.Auditoria.DTO;
using CGJ.Application.Auditoria.Service.Interfaces;
using CGJ.Application.Service;
using CGJ.Domain.Auditoria.Repository;

namespace CGJ.Application.Auditoria.Service
{
    public class AuditoriaService : ServiceBase<CGJ.Domain.Auditoria.Auditoria, Guid, AuditoriaInputDTO, AuditoriaUpdateDTO, AuditoriaOutputDTO>,
        IAuditoriaService<Guid, AuditoriaInputDTO, AuditoriaUpdateDTO, AuditoriaOutputDTO>
    {
        public AuditoriaService(IAuditoriaRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

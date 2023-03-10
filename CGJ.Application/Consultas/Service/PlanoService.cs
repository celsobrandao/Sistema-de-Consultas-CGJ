using AutoMapper;
using CGJ.Application.Consultas.DTO;
using CGJ.Application.Consultas.Service.Interfaces;
using CGJ.Application.Service;
using CGJ.Domain.Consultas;
using CGJ.Domain.Consultas.Repository;

namespace CGJ.Application.Consultas.Service
{
    public class PlanoService : ServiceBase<Plano, Guid, PlanoInputDTO, PlanoUpdateDTO, PlanoOutputDTO>,
        IPlanoService<Guid, PlanoInputDTO, PlanoUpdateDTO, PlanoOutputDTO>
    {
        public PlanoService(IPlanoRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

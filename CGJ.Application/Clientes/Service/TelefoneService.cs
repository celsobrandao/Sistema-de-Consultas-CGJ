using AutoMapper;
using CGJ.Application.Clientes.DTO;
using CGJ.Application.Clientes.Service.Interfaces;
using CGJ.Application.Service;
using CGJ.Domain.Clientes;
using CGJ.Domain.Clientes.Repository;

namespace CGJ.Application.Clientes.Service
{
    public class TelefoneService : ServiceBase<Telefone, Guid, TelefoneInputDTO, TelefoneUpdateDTO, TelefoneOutputDTO>,
        ITelefoneService<Guid, TelefoneInputDTO, TelefoneUpdateDTO, TelefoneOutputDTO>
    {
        public TelefoneService(ITelefoneRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

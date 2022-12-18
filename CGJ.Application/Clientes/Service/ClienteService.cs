using AutoMapper;
using CGJ.Application.Clientes.DTO;
using CGJ.Application.Clientes.Service.Interfaces;
using CGJ.Application.Service;
using CGJ.Domain.Clientes;
using CGJ.Domain.Clientes.Repository;

namespace CGJ.Application.Clientes.Service
{
    public class ClienteService : ServiceBase<Cliente, Guid, ClienteInputDTO, ClienteUpdateDTO, ClienteOutputDTO>,
        IClienteService<Guid, ClienteInputDTO, ClienteUpdateDTO, ClienteOutputDTO>
    {
        public ClienteService(IClienteRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

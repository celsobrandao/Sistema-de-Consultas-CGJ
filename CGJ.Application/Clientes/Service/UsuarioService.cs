using AutoMapper;
using CGJ.Application.Clientes.DTO;
using CGJ.Application.Clientes.Service.Interfaces;
using CGJ.Application.Service;
using CGJ.Domain.Clientes;
using CGJ.Domain.Clientes.Repository;

namespace CGJ.Application.Clientes.Service
{
    public class UsuarioService : ServiceBase<Usuario, Guid, UsuarioInputDTO, UsuarioUpdateDTO, UsuarioOutputDTO>,
        IUsuarioService<Guid, UsuarioInputDTO, UsuarioUpdateDTO, UsuarioOutputDTO>
    {
        public UsuarioService(IUsuarioRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

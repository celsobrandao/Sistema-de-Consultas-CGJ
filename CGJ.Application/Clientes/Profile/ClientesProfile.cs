using CGJ.Application.Clientes.DTO;
using CGJ.Domain.Clientes;

namespace CGJ.Application.Clientes.Profile
{
    public class ClientesProfile : AutoMapper.Profile
    {
        public ClientesProfile()
        {
            CreateMap<Cliente, ClienteOutputDTO>();
            CreateMap<ClienteInputDTO, Cliente>();
            CreateMap<ClienteUpdateDTO, Cliente>();

            CreateMap<Telefone, TelefoneOutputDTO>();
            CreateMap<TelefoneInputDTO, Telefone>();
            CreateMap<TelefoneUpdateDTO, Telefone>();

            CreateMap<Usuario, UsuarioOutputDTO>()
                .ForMember(x => x.Login, f => f.MapFrom(m => m.Autenticacao.Login));
            CreateMap<UsuarioInputDTO, Usuario>()
                .ForMember(x => x.Autenticacao.Login, f => f.MapFrom(m => m.Login))
                .ForMember(x => x.Autenticacao.Senha, f => f.MapFrom(m => m.Senha));
            CreateMap<UsuarioUpdateDTO, Usuario>()
                .ForMember(x => x.Autenticacao.Login, f => f.MapFrom(m => m.Login))
                .ForMember(x => x.Autenticacao.Senha, f => f.MapFrom(m => m.Senha));
        }
    }
}

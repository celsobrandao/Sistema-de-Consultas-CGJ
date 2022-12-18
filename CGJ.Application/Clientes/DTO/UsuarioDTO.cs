using CGJ.Application.Consultas.DTO;

namespace CGJ.Application.Clientes.DTO
{
    public record UsuarioInputDTO(ClienteInputDTO Cliente, string Nome, string Login, string Senha, bool Administrador);

    public record UsuarioUpdateDTO(Guid Codigo, ClienteInputDTO Cliente, string Nome, string Login, string Senha, bool Administrador);

    public record UsuarioOutputDTO(Guid Codigo, ClienteOutputDTO Cliente, string Nome, string Login, bool Administrador, List<OperacaoOutputDTO> Operacoes);
}

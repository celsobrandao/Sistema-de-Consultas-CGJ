using CGJ.Application.Consultas.DTO;

namespace CGJ.Application.Clientes.DTO
{
    public record ClienteInputDTO(PlanoInputDTO Plano, string Nome, string CNPJ, List<TelefoneInputDTO> Telefones, List<UsuarioInputDTO> Usuarios);

    public record ClienteUpdateDTO(Guid Codigo, PlanoInputDTO Plano, string Nome, string CNPJ, List<TelefoneInputDTO> Telefones, List<UsuarioInputDTO> Usuarios);

    public record ClienteOutputDTO(Guid Codigo, PlanoOutputDTO Plano, string Nome, string CNPJ, List<TelefoneOutputDTO> Telefones, List<UsuarioOutputDTO> Usuarios);
}
using CGJ.Application.Auditoria.DTO;
using CGJ.Application.Clientes.DTO;

namespace CGJ.Application.Consultas.DTO
{
    public record OperacaoInputDTO(ConsultaInputDTO Consulta, UsuarioInputDTO Usuario, DateTime Data, string Descricao);

    public record OperacaoUpdateDTO(Guid Codigo, ConsultaInputDTO Consulta, UsuarioInputDTO Usuario, DateTime Data, string Descricao);

    public record OperacaoOutputDTO(Guid Codigo, ConsultaOutputDTO Consulta, UsuarioOutputDTO Usuario, DateTime Data, string Descricao, List<AuditoriaOutputDTO> Auditorias);
}

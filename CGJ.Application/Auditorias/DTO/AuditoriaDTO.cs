using CGJ.Application.Consultas.DTO;

namespace CGJ.Application.Auditorias.DTO
{
    public record AuditoriaInputDTO(OperacaoInputDTO Operacao, DateTime Data);

    public record AuditoriaUpdateDTO(Guid Codigo, OperacaoInputDTO Operacao, DateTime Data);

    public record AuditoriaOutputDTO(Guid Codigo, OperacaoOutputDTO Operacao, DateTime Data);
}

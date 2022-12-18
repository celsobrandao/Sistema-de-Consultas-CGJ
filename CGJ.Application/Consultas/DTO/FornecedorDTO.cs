namespace CGJ.Application.Consultas.DTO
{
    public record FornecedorInputDTO(string Nome, string Descricao, string Telefone, List<ConsultaInputDTO> Consultas);

    public record FornecedorUpdateDTO(Guid Codigo, string Nome, string Descricao, string Telefone, List<ConsultaInputDTO> Consultas);

    public record FornecedorOutputDTO(Guid Codigo, string Nome, string Descricao, string Telefone, List<ConsultaOutputDTO> Consultas, List<ContratoOutputDTO> Contratos);
}

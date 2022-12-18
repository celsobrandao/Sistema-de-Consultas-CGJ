namespace CGJ.Application.Consultas.DTO
{
    public record ContratoInputDTO(ConsultaInputDTO Consulta, FornecedorInputDTO Fornecedor, DateTime DataVigencia, decimal Valor);

    public record ContratoUpdateDTO(Guid Codigo, ConsultaInputDTO Consulta, FornecedorInputDTO Fornecedor, DateTime DataVigencia, decimal Valor);

    public record ContratoOutputDTO(Guid Codigo, ConsultaOutputDTO Consulta, FornecedorOutputDTO Fornecedor, DateTime DataVigencia, decimal Valor);
}

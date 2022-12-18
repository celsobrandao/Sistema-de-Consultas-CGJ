namespace CGJ.Application.Consultas.DTO
{
    public record ConsultaInputDTO(FornecedorInputDTO Fornecedor, string Nome, string Descricao, string Url, string Login, string Senha, List<ContratoInputDTO> Contratos);

    public record ConsultaUpdateDTO(Guid Codigo, FornecedorInputDTO Fornecedor, string Nome, string Descricao, string Url, string Login, string Senha, List<ContratoInputDTO> Contratos);

    public record ConsultaOutputDTO(Guid Codigo, FornecedorInputDTO Fornecedor, string Nome, string Descricao, string Url, string Login, List<ContratoOutputDTO> Contratos, List<OperacaoOutputDTO> Operacoes);
}

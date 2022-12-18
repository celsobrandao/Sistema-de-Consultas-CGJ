namespace CGJ.Application.Consultas.DTO
{
    public record PlanoInputDTO(string Nome, string Descricao, DateTime DataVigencia, decimal Valor);

    public record PlanoUpdateDTO(Guid Codigo, string Nome, string Descricao, DateTime DataVigencia, decimal Valor);

    public record PlanoOutputDTO(Guid Codigo, string Nome, string Descricao, DateTime DataVigencia, decimal Valor);
}

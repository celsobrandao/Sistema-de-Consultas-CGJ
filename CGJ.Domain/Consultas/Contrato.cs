using CGJ.Infra.Entidade;

namespace CGJ.Domain.Consultas
{
    public class Contrato : Entidade<Guid>
    {
        public Consulta Consulta { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public DateTime DataVigencia { get; set; }
        public decimal Valor { get; set; }
    }
}

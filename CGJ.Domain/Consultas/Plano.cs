using CGJ.Infra.Entidade;

namespace CGJ.Domain.Consultas
{
    public class Plano : Entidade<Guid>
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataVigencia { get; set; }
        public decimal Valor { get; set; }
    }
}

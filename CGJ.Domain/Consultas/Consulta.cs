using CGJ.Domain.Shared.ValueObjects;
using CGJ.Infra.Entidade;

namespace CGJ.Domain.Consultas
{
    public class Consulta : Entidade<Guid>
    {
        public Fornecedor Fornecedor { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Url { get; set; }
        public Autenticacao Autenticacao { get; set; }
        public List<Contrato> Contratos { get; set; }
        public List<Operacao> Operacoes { get; set; }
    }
}

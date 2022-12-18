using CGJ.Infra.Entidade;

namespace CGJ.Domain.Consultas
{
    public class Fornecedor : Entidade<Guid>
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Telefone { get; set; }
        public List<Consulta> Consultas { get; set; }
        public List<Contrato> Contratos { get; set; }
    }
}

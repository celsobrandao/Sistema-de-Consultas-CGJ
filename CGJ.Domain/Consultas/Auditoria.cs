using CGJ.Infra.Entidade;

namespace CGJ.Domain.Consultas
{
    public class Auditoria : Entidade<Guid>
    {
        public Operacao Operacao { get; set; }
        public DateTime Data { get; set; }
    }
}

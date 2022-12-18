using CGJ.Domain.Consultas;
using CGJ.Infra.Entidade;

namespace CGJ.Domain.Auditorias
{
    public class Auditoria : Entidade<Guid>
    {
        public Operacao Operacao { get; set; }
        public DateTime Data { get; set; }
    }
}

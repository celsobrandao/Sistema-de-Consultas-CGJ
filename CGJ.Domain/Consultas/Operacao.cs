using CGJ.Domain.Clientes;
using CGJ.Infra.Entidade;

namespace CGJ.Domain.Consultas
{
    public class Operacao : Entidade<Guid>
    {
        public Consulta Consulta { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public List<Auditoria> Auditorias { get; set; }
    }
}

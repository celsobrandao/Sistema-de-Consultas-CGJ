using CGJ.Domain.Consultas;
using CGJ.Domain.Shared.ValueObjects;
using CGJ.Infra.Entidade;

namespace CGJ.Domain.Clientes
{
    public class Usuario : Entidade<Guid>
    {
        public Cliente Cliente { get; set; }
        public string Nome { get; set; }
        public Autenticacao Autenticacao { get; set; }
        public bool Administrador { get; set; }
        public List<Operacao> Operacoes { get; set; }
    }
}

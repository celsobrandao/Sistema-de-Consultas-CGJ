using CGJ.Domain.Consultas;
using CGJ.Infra.Entidade;

namespace CGJ.Domain.Clientes
{
    public class Cliente : Entidade<Guid>
    {
        public Plano Plano { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public List<Telefone> Telefones { get; set; }
        public List<Usuario> Usuarios { get; set; }
    }
}
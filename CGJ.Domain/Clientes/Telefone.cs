using CGJ.Infra.Entidade;

namespace CGJ.Domain.Clientes
{
    public class Telefone : Entidade<Guid>
    {
        public Cliente Cliente { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
    }
}

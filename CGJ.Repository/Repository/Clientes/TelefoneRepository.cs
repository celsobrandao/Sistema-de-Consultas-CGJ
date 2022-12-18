using CGJ.Domain.Clientes;
using CGJ.Domain.Clientes.Repository;
using CGJ.Repository.Context;
using CGJ.Repository.Database;

namespace CGJ.Repository.Repository.Clientes
{
    public class TelefoneRepository : Repository<Telefone>, ITelefoneRepository
    {
        public TelefoneRepository(CGJContext context) : base(context)
        {
        }
    }
}

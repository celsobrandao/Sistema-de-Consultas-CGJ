using CGJ.Domain.Clientes;
using CGJ.Domain.Clientes.Repository;
using CGJ.Repository.Context;
using CGJ.Repository.Database;

namespace CGJ.Repository.Repository.Clientes
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(CGJContext context) : base(context)
        {
        }
    }
}

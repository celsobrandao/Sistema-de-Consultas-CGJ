using CGJ.Domain.Clientes;
using CGJ.Domain.Clientes.Repository;
using CGJ.Repository.Context;
using CGJ.Repository.Database;

namespace CGJ.Repository.Repository.Clientes
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(CGJContext context) : base(context)
        {
        }
    }
}

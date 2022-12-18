using CGJ.Domain.Consultas;
using CGJ.Domain.Consultas.Repository;
using CGJ.Repository.Context;
using CGJ.Repository.Database;

namespace CGJ.Repository.Repository.Consultas
{
    public class PlanoRepository : Repository<Plano>, IPlanoRepository
    {
        public PlanoRepository(CGJContext context) : base(context)
        {
        }
    }
}

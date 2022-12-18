using CGJ.Domain.Consultas;
using CGJ.Domain.Consultas.Repository;
using CGJ.Repository.Context;
using CGJ.Repository.Database;

namespace CGJ.Repository.Repository.Consultas
{
    public class AuditoriaRepository : Repository<Auditoria>, IAuditoriaRepository
    {
        public AuditoriaRepository(CGJContext context) : base(context)
        {
        }
    }
}

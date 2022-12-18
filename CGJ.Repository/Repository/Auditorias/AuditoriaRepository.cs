using CGJ.Domain.Auditorias;
using CGJ.Domain.Auditorias.Repository;
using CGJ.Repository.Context;
using CGJ.Repository.Database;

namespace CGJ.Repository.Repository.Auditorias
{
    public class AuditoriaRepository : Repository<Auditoria>, IAuditoriaRepository
    {
        public AuditoriaRepository(CGJContext context) : base(context)
        {
        }
    }
}

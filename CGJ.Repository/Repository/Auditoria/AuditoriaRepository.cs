using CGJ.Domain.Auditoria.Repository;
using CGJ.Repository.Context;
using CGJ.Repository.Database;

namespace CGJ.Repository.Repository.Auditoria
{
    public class AuditoriaRepository : Repository<CGJ.Domain.Auditoria.Auditoria>, IAuditoriaRepository
    {
        public AuditoriaRepository(CGJContext context) : base(context)
        {
        }
    }
}

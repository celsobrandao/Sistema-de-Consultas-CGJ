using CGJ.Domain.Consultas;
using CGJ.Domain.Consultas.Repository;
using CGJ.Repository.Context;
using CGJ.Repository.Database;

namespace CGJ.Repository.Repository.Consultas
{
    public class ConsultaRepository : Repository<Consulta>, IConsultaRepository
    {
        public ConsultaRepository(CGJContext context) : base(context)
        {
        }
    }
}

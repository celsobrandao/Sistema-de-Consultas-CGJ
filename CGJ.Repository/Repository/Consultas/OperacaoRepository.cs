using CGJ.Domain.Consultas;
using CGJ.Domain.Consultas.Repository;
using CGJ.Repository.Context;
using CGJ.Repository.Database;

namespace CGJ.Repository.Repository.Consultas
{
    public class OperacaoRepository : Repository<Operacao>, IOperacaoRepository
    {
        public OperacaoRepository(CGJContext context) : base(context)
        {
        }
    }
}

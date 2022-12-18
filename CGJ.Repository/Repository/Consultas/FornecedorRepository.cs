using CGJ.Domain.Consultas;
using CGJ.Domain.Consultas.Repository;
using CGJ.Repository.Context;
using CGJ.Repository.Database;

namespace CGJ.Repository.Repository.Consultas
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(CGJContext context) : base(context)
        {
        }
    }
}

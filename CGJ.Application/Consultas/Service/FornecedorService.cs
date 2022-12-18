using AutoMapper;
using CGJ.Application.Consultas.DTO;
using CGJ.Application.Consultas.Service.Interfaces;
using CGJ.Application.Service;
using CGJ.Domain.Consultas;
using CGJ.Domain.Consultas.Repository;

namespace CGJ.Application.Consultas.Service
{
    public class FornecedorService : ServiceBase<Fornecedor, Guid, FornecedorInputDTO, FornecedorUpdateDTO, FornecedorOutputDTO>,
        IFornecedorService<Guid, FornecedorInputDTO, FornecedorUpdateDTO, FornecedorOutputDTO>
    {
        public FornecedorService(IFornecedorRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}

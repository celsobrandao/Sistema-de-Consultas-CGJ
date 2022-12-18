using CGJ.Application.Consultas.DTO;
using CGJ.Domain.Consultas;

namespace CGJ.Application.Consultas.Profile
{
    public class ConsultasProfile : AutoMapper.Profile
    {
        public ConsultasProfile()
        {
            CreateMap<Auditoria, AuditoriaOutputDTO>();
            CreateMap<AuditoriaInputDTO, Auditoria>();
            CreateMap<AuditoriaUpdateDTO, Auditoria>();

            CreateMap<Consulta, ConsultaOutputDTO>()
                .ForMember(x => x.Login, f => f.MapFrom(m => m.Autenticacao.Login));
            CreateMap<ConsultaInputDTO, Consulta>()
                .ForMember(x => x.Autenticacao.Login, f => f.MapFrom(m => m.Login))
                .ForMember(x => x.Autenticacao.Senha, f => f.MapFrom(m => m.Senha));
            CreateMap<ConsultaUpdateDTO, Consulta>()
                .ForMember(x => x.Autenticacao.Login, f => f.MapFrom(m => m.Login))
                .ForMember(x => x.Autenticacao.Senha, f => f.MapFrom(m => m.Senha));

            CreateMap<Contrato, ContratoOutputDTO>();
            CreateMap<ContratoInputDTO, Contrato>();
            CreateMap<ContratoUpdateDTO, Contrato>();

            CreateMap<Fornecedor, FornecedorOutputDTO>();
            CreateMap<FornecedorInputDTO, Fornecedor>();
            CreateMap<FornecedorUpdateDTO, Fornecedor>();

            CreateMap<Operacao, OperacaoOutputDTO>();
            CreateMap<OperacaoInputDTO, Operacao>();
            CreateMap<OperacaoUpdateDTO, Operacao>();

            CreateMap<Plano, PlanoOutputDTO>();
            CreateMap<PlanoInputDTO, Plano>();
            CreateMap<PlanoUpdateDTO, Plano>();
        }
    }
}

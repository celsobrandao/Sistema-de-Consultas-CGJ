using CGJ.Domain.Consultas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CGJ.Repository.Mapping.Consultas
{
    public class OperacaoMapping : IEntityTypeConfiguration<Operacao>
    {
        public void Configure(EntityTypeBuilder<Operacao> builder)
        {
            builder.ToTable("Operacoes");

            builder.HasKey(x => x.Codigo);

            builder.Property(x => x.Data)
                .IsRequired();

            builder.Property(x => x.Descricao)
                .IsRequired();

            builder.HasMany(x => x.Auditorias)
                .WithOne(x => x.Operacao)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

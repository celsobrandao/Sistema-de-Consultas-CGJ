using CGJ.Domain.Consultas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CGJ.Repository.Mapping.Consultas
{
    public class ContratoMapping : IEntityTypeConfiguration<Contrato>
    {
        public void Configure(EntityTypeBuilder<Contrato> builder)
        {
            builder.ToTable("Contratos");

            builder.HasKey(x => x.Codigo);

            builder.Property(x => x.DataVigencia)
                .IsRequired();

            builder.Property(x => x.Valor)
                .IsRequired();
        }
    }
}

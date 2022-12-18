using CGJ.Domain.Consultas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CGJ.Repository.Mapping.Consultas
{
    public class ConsultaMapping : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.ToTable("Consultas");

            builder.HasKey(x => x.Codigo);

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Descricao)
                .IsRequired();

            builder.Property(x => x.Url)
                .IsRequired();

            builder.OwnsOne(x => x.Autenticacao, p =>
            {
                p.Property(f => f.Login)
                    .IsRequired();

                p.Property(f => f.Senha)
                    .IsRequired();
            });

            builder.HasMany(x => x.Contratos)
                .WithOne(x => x.Consulta)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.Operacoes)
                .WithOne(x => x.Consulta)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

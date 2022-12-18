using CGJ.Domain.Consultas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CGJ.Repository.Mapping.Consultas
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedores");

            builder.HasKey(x => x.Codigo);

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.Descricao)
                .IsRequired();

            builder.Property(x => x.Telefone)
                .IsRequired();

            builder.HasMany(x => x.Consultas)
                .WithOne(x => x.Fornecedor)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(x => x.Contratos)
                .WithOne(x => x.Fornecedor)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

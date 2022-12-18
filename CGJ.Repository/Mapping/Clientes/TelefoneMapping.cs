using CGJ.Domain.Clientes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CGJ.Repository.Mapping.Clientes
{
    public class TelefoneMapping : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.ToTable("Telefones");

            builder.HasKey(x => x.Codigo);

            builder.Property(x => x.Codigo)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Numero)
                .IsRequired()
                .HasMaxLength(9);

            builder.Property(x => x.Complemento)
                .HasMaxLength(100);
        }
    }
}

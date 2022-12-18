using CGJ.Domain.Clientes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CGJ.Repository.Mapping.Clientes
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");

            builder.HasKey(x => x.Codigo);

            builder.Property(x => x.Codigo)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(x => x.CNPJ)
                .IsRequired()
                .HasMaxLength(14);

            builder.HasOne(x => x.Plano)
                .WithMany();

            builder.HasMany(x => x.Telefones)
                .WithOne(x => x.Cliente)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            builder.HasMany(x => x.Usuarios)
                .WithOne(x => x.Cliente)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

using CGJ.Domain.Clientes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CGJ.Repository.Mapping.Clientes
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(x => x.Codigo);

            builder.Property(x => x.Codigo)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(200);

            builder.OwnsOne(x => x.Autenticacao, p =>
            {
                p.Property(f => f.Login)
                    .IsRequired();

                p.Property(f => f.Senha)
                    .IsRequired();
            });

            builder.Property(x => x.Administrador)
                .IsRequired();

            builder.HasMany(x => x.Operacoes)
                .WithOne(x => x.Usuario)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

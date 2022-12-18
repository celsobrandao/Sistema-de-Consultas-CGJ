using CGJ.Domain.Auditorias;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CGJ.Repository.Mapping.Auditorias
{
    public class AuditoriaMapping : IEntityTypeConfiguration<Auditoria>
    {
        public void Configure(EntityTypeBuilder<Auditoria> builder)
        {
            builder.ToTable("Auditorias");

            builder.HasKey(x => x.Codigo);

            builder.Property(x => x.Data)
                .IsRequired();
        }
    }
}

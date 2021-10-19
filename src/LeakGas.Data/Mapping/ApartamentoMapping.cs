using LeakGas.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeakGas.Data.Mapping
{
    public class ApartamentoMapping : IEntityTypeConfiguration<Apartamento>
    {
        public void Configure(EntityTypeBuilder<Apartamento> builder)
        {
            builder.HasMany(u => u.UsuariosApartamentos)
                   .WithOne(uc => uc.Apartamento)
                   .HasForeignKey(uc => uc.IdApartamento);
        }
    }
}

using LeakGas.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeakGas.Data.Mapping
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasMany(u => u.UsuariosApartamentos)
                    .WithOne(uc => uc.Usuario)
                    .HasForeignKey(uc => uc.IdUsuario);
        }
    }
}

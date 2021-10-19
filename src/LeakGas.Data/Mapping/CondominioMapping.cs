using LeakGas.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeakGas.Data.Mapping
{
    public class CondominioMapping : IEntityTypeConfiguration<Condominio>
    {
        public void Configure(EntityTypeBuilder<Condominio> builder)
        {
            builder.HasMany(u => u.Apartamentos)
                    .WithOne(uc => uc.Condominio)
                    .HasForeignKey(uc => uc.IdCondominio);
        }
    }
}

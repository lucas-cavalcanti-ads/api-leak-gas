using LeakGas.Business.Interfaces.Data;
using LeakGas.Business.Models;
using LeakGas.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace LeakGas.Data.Repositories
{
    public class UsuarioApartamentoRepository : Repository<UsuarioApartamento>, IUsuarioApartamentoRepository
    {
        public  UsuarioApartamentoRepository(LeakGasContext db) : base(db)
        {
        }

        public async Task<IEnumerable<UsuarioApartamento>> BuscarListaCondominioPorIdUsuario(int idUsuario)
        {
            return await Db.UsuarioApartamento.AsNoTracking()
                .Include(uc => uc.Apartamento).Where(uc => uc.IdUsuario == idUsuario).ToListAsync();
        }

    }
}

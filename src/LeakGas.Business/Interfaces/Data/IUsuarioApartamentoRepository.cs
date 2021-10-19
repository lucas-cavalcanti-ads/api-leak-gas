using LeakGas.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeakGas.Business.Interfaces.Data
{
    public interface IUsuarioApartamentoRepository : IRepository<UsuarioApartamento>
    {
        Task<IEnumerable<UsuarioApartamento>> BuscarListaCondominioPorIdUsuario(int idUsuario);

    }
}

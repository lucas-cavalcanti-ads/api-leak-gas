using LeakGas.Business.Interfaces.Data;
using LeakGas.Business.Models;
using LeakGas.Data.Context;
using System.Linq;
using System.Threading.Tasks;

namespace LeakGas.Data.Repositories
{
    public class LoginRepository : Repository<Login>, ILoginRepository
    {
        public LoginRepository(LeakGasContext db) : base(db)
        {
        }

        public Login BuscarLoginPorIdUsuario(int idUsuario)
        {
            return Db.Login.FirstOrDefault(l => l.IdUsuario == idUsuario);
        }
    }
}

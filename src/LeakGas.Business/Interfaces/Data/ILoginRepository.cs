using LeakGas.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LeakGas.Business.Interfaces.Data
{
    public interface ILoginRepository : IRepository<Login>
    {
        Login BuscarLoginPorIdUsuario(int idUsuario);
    }
}

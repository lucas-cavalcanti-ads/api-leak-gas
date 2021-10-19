using LeakGas.Business.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeakGas.Business.Interfaces.Data
{
    public interface IOcorrenciaRepository : IRepository<Ocorrencia>
    {
        Task<IEnumerable<ViewAlarme>> PegarViewAlarme(int idCondominio);
    }
}

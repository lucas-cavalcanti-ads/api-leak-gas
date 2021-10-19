using LeakGas.Business.Interfaces.Data;
using LeakGas.Business.Models;
using LeakGas.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeakGas.Data.Repositories
{
    public class OcorrenciaRepository : Repository<Ocorrencia>, IOcorrenciaRepository
    {
        public  OcorrenciaRepository(LeakGasContext db) : base(db)
        {
        }

        public async Task<IEnumerable<ViewAlarme>> PegarViewAlarme(int idCondominio)
        {
            return await Db.ViewAlarme.AsNoTracking().Where(va => va.IdCondominio == idCondominio).ToListAsync();
        }
    }
}

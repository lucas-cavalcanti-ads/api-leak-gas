using LeakGas.Api.DTO;
using LeakGas.Api.Wrapper;
using LeakGas.Business.Interfaces;
using LeakGas.Business.Interfaces.Data;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace LeakGas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaoController : MainController
    {
        private readonly ILoginRepository _loginRepository;
        public AutenticacaoController(INotificador notificador, ILoginRepository loginRepository) : base(notificador)
        {
            _loginRepository = loginRepository;
        }

        [HttpPost]
        [SwaggerResponse(200, type: typeof(Response))]
        public async Task<ActionResult> Login(LoginDTO loginDTO)
        {
            try
            {
                if (!ModelState.IsValid) return CustomResponse(ModelState);

                var resp = await _loginRepository.Buscar(l => l.Usuario == loginDTO.Usuario && l.Senha == loginDTO.Senha);

                if (resp.Count > 0)
                {
                    return CustomResponse(new { IdUsuario = resp[0].IdUsuario });
                }
                NotificarErro("Usuário ou senha incorretos");
                return CustomResponse();
            }
            catch (System.Exception e)
            {

                NotificarErro(e.Message);
            }
            return CustomResponse();
        }
    }
}

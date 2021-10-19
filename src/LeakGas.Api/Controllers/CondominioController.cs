using AutoMapper;
using LeakGas.Api.DTO;
using LeakGas.Api.Wrapper;
using LeakGas.Business.Interfaces;
using LeakGas.Business.Interfaces.Data;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace LeakGas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CondominioController : MainController
    {
        private readonly ICondominioRepository _condominioRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        public CondominioController(INotificador notificador, ICondominioRepository condominioRepository, IUsuarioRepository usuarioRepository, IMapper mapper) : base(notificador)
        {
            _condominioRepository = condominioRepository;
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [SwaggerResponse(200, type: typeof(Response<CondominioDTO>))]
        public async Task<ActionResult> ListaCondominiosByIdUsuario(int idUsuario)
        {
            try
            {
                var listaUsuCondo =  await _usuarioRepository.BuscarCondominioPorUsuario(idUsuario);

                var condominios = listaUsuCondo.ToList()[0].UsuariosApartamentos.Select(ua => ua.Apartamento.Condominio);

                var response = _mapper.Map<IEnumerable<CondominioDTO>>(condominios);

                return CustomResponse(response);
            }
            catch (System.Exception e)
            {

                NotificarErro(e.Message);
            }
            return CustomResponse();
        }
    }
}
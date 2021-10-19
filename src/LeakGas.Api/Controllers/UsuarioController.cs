using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LeakGas.Api.DTO;
using LeakGas.Api.Wrapper;
using LeakGas.Business.Interfaces;
using LeakGas.Business.Interfaces.Data;
using LeakGas.Business.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace LeakGas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : MainController
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ILoginRepository _loginRepository;
        private readonly IUsuarioApartamentoRepository _usuarioApartamentoRepository;
        private readonly IMapper _mapper;
        public UsuarioController(INotificador notificador, IUsuarioRepository usuarioRepository, ILoginRepository loginRepository, IUsuarioApartamentoRepository usuarioApartamentoRepository, IMapper mapper) : base(notificador)
        {
            _usuarioRepository = usuarioRepository;
            _loginRepository = loginRepository;
            _usuarioApartamentoRepository = usuarioApartamentoRepository;
            _mapper = mapper;
        }

        [HttpDelete]
        [SwaggerResponse(200, type: typeof(Response))]
        public async Task<ActionResult> DeletarUsuario(int idUsuario)
        {
            try
            {
                if (!ModelState.IsValid) return CustomResponse(ModelState);

                if (idUsuario <= 0)
                {
                    NotificarErro("Id inválido");
                    return CustomResponse();
                }

                var usuario = await _usuarioRepository.ObterPorId(idUsuario);
                if (usuario == null)
                {
                    NotificarErro($"Usuário com id {idUsuario} não encontrado no sistema.");
                    return CustomResponse();
                }
                var loginUsu = _loginRepository.BuscarLoginPorIdUsuario(idUsuario);

                if (loginUsu != null)
                {

                    await _loginRepository.Remover(loginUsu);
                }

                var listaUsuarioApto = await _usuarioApartamentoRepository.Buscar(ua => ua.IdUsuario == idUsuario);

                foreach (var item in listaUsuarioApto)
                {
                    await _usuarioApartamentoRepository.Remover(item);
                }

                await _usuarioRepository.Remover(usuario);
            }
            catch (System.Exception e)
            {

                NotificarErro(e.Message);
            }
            return CustomResponse();
        }

        [HttpPut]
        [SwaggerResponse(200, type: typeof(Response))]
        public async Task<ActionResult> AtualizarUsuario(UsuarioDTO usuario)
        {
            try
            {
                if (!ModelState.IsValid) return CustomResponse(ModelState);

                var usu = _mapper.Map<Usuario>(usuario);

                await _usuarioRepository.Atualizar(usu);
            }
            catch (System.Exception e)
            {

                NotificarErro(e.Message);
            }
            return CustomResponse();
        }

        [HttpGet()]
        [SwaggerResponse(200, type: typeof(Response<IEnumerable<UsuarioDadosDTO>>))]
        public async Task<ActionResult> BuscarDadosUsuarioIdCondominio(int idCondominio)
        {
            try
            {
                if (!ModelState.IsValid) return CustomResponse(ModelState);

                if (idCondominio <= 0)
                {
                    NotificarErro("Id inválido");
                    return CustomResponse();
                }

                var resposta = await _usuarioRepository.BuscarViewPorCondominio(idCondominio);

                var usu = _mapper.Map<IEnumerable<UsuarioDadosDTO>>(resposta);

                return CustomResponse(usu);
            }
            catch (System.Exception e)
            {

                NotificarErro(e.Message);
            }
            return CustomResponse();
        }

        [HttpPost]
        [SwaggerResponse(200, type: typeof(Response))]
        public async Task<ActionResult> CadastrarUsuario(CadastroUsuarioDTO usuarioDTO)
        {
            try
            {
                if (!ModelState.IsValid) return CustomResponse(ModelState);


                 _usuarioRepository.CadastroProcedure(usuarioDTO.Nome, usuarioDTO.Cpf, usuarioDTO.Telefone, usuarioDTO.Login, usuarioDTO.Senha, usuarioDTO.NivelAcesso);

            }
            catch (System.Exception e)
            {

                NotificarErro(e.Message);
            }
            return CustomResponse();
        }


    }
}
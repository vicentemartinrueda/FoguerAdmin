using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.DTO;
using Service.Service;

namespace FoguerAppApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService ?? throw new ArgumentNullException(nameof(usuarioService));
        }

        /// <summary>
        /// Obtenemos todas los Usuarios disponibles
        /// </summary>
        /// <returns></returns>
        // GET: api/Usuario
        [HttpGet]
        public async Task<ActionResult<List<DtoUsuario>>> GetUsuarios()
        {
            List<DtoUsuario> usuario = await _usuarioService.Get();
            return usuario;
        }
    }
}
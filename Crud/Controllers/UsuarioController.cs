using Crud.Services;
using Microsoft.AspNetCore.Mvc;

namespace Crud.Controllers
{
    [ApiController]
    public class UsuarioController: Controller
    {
        private readonly UsuariosService _service;

        public UsuarioController(UsuariosService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("/usuarios/get")]
        public IActionResult GetAllUsuario()
        {
            var usuarios = _service.GetAllUsuarios();

            return Ok(usuarios);
        }
    }
}

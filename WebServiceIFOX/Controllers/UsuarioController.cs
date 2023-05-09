using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebServiceIFOX.Models;

namespace WebServiceIFOX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        //SERVIÇOS RELACIONADOS AO USUÁRIO
        [HttpPost]
        [Route("/api/[controller]/Cadastrar")]
        public IActionResult CadastrarUsuario([FromBody] Usuario usuario) {
            
            return Ok(new { mensagem = usuario.cadastrarUsuario() } );
        }

        [HttpPost]
        [Route("/api/[controller]/Logar")]
        public IActionResult LogarUsuario([FromBody] Usuario usuario) {

            return Ok(new { mensagem = usuario.logarUsuario() });
        }

    }
}

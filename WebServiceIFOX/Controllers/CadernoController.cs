using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebServiceIFOX.Models;

namespace WebServiceIFOX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadernoController : ControllerBase
    {
        [HttpPost]
        public IActionResult CadastrarCaderno([FromBody] Caderno caderno)
        {
            caderno.cadastrarCaderno();
            return Ok(new { mensagem = caderno.cadastrarCaderno() });
        }
        //slaaa
        //[HttpGet]
        //public IActionResult ListarCaderno([FromBody] string nomeUsuario)
        //{
        //    return Caderno.listarCaderno(nomeUsuario);
        //}
    }
}

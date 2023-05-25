using Microsoft.AspNetCore.Mvc;
using WebServiceIFOX.Models;

namespace WebServiceIFOX.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]

    public class ResumoController : ControllerBase

        {

        //listar todos os resumos
        [HttpGet]
        public List<Resumo> ListarResumo(int nomeUsuario)
            {
            return Resumo.listarResumo(nomeUsuario);
            }
        //cadasatrar resumo escrito
        [HttpPost]
        public IActionResult CadastrarResumo([FromBody] Resumo resumo)
            {
            resumo.cadastrarResumo();
            return Ok(new { mensagem = resumo.cadastrarResumo() });
            }
        //Deletar um resumo
        [HttpDelete]
        public IActionResult DeletarResumo( int id_resumo)
            {
            Resumo.deletarResumo(id_resumo);
            return Ok(new { mensagem = Resumo.deletarResumo(id_resumo) });
            }
        //Editar um resumo escrito
        [HttpPut]
        public IActionResult EditarResumo(string titulo, string texto, int codigo)
            {
            Resumo.editarResumo(titulo, texto, codigo);
            return Ok(new { mensagem = Resumo.editarResumo(titulo, texto, codigo) });
            }
        }
    
}

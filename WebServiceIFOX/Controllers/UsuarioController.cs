﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto.Digests;
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
        public IActionResult CadastrarUsuario([FromBody] Usuario usuario)
        {

            return Ok(new { mensagem = usuario.cadastrarUsuario() });
        }

        [HttpPost]
        [Route("/api/[controller]/Logar")]
        public IActionResult LogarUsuario([FromBody] Usuario usuario)
        {

            return Ok(new { mensagem = usuario.logarUsuario() });
        }

        [HttpGet]
        public Usuario Listar(string nome)
        {
            Usuario usuario = new Usuario();
            usuario = usuario.listarUsuario(nome);
            return usuario;
        }

        [HttpPut]
        public IActionResult Ataualizar([FromBody] Usuario usuario) {
            string nome = usuario.Nome;
            return Ok(new { mensagem = usuario.atualizarUsuario(nome) });
        }

    }

}
